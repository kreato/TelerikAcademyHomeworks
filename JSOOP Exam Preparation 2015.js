function solve() {
    var module = (function() {
        var playable,
            audio,
            video,
            playlist,
            player,
            TEXT_MIN_LENGTH = 3,
            TEXT_MAX_LENGTH = 25,
            MIN_RATING = 1,
            MAX_RATING = 5;

        function indexOfElementWithIdInCollection(collection, id) {
            var i,
                len;
            for (i = 0, len = collection.length; i < len; i += 1) {
                if (collection[i].id == id) {
                    return i;
                }
            }

            return -1;
        }

        function validateIfObject(val, name) {
            name = name || 'Value';
            if (typeof(val) !== 'object') {
                throw new Error(name + ' must be an object');
            }
        }

        function validateIfUndefined(val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined')
            }
        }

        function validateString(val, name) {
            name = name || 'Value';
            validateIfUndefined(val, name);

            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }

            if (val.length < TEXT_MIN_LENGTH || val.length > TEXT_MAX_LENGTH) {
                throw new Error(name + ' must be between ' + TEXT_MIN_LENGTH + ' and ' + TEXT_MAX_LENGTH + ' symbols');
            }
        }

        function validateIfNumber(val, name) {
            name = name || 'Value';
            if (typeof(val) !== 'number') {
                throw new Error(name + ' must be a number');
            }
        }

        function validatePositiveNumber(val, name) {
            name = name || 'Value';
            validateIfUndefined(val, name);
            validateIfNumber(val, name);

            if (val <= 0) {
                throw new Error(name + ' must be positive number');
            }
        }

        function validateImdbRating(val, name) {
            validateIfUndefined(val, name);
            validateIfNumber(val, name);
            if (val < MIN_RATING || val > MAX_RATING) {
                throw new Error('IMDB Rating must be between ' + MIN_RATING + ' and ' + MAX_RATING);
            }
        }

        function validateId(id) {
            validateIfUndefined(id, 'Object id');
            if (typeof id !== 'number') {
                id = id.id;
            }

            validateIfUndefined(id, 'Object must have id');
            return id;
        }

        playable = (function() {
            var playable = Object.create({}),
                lastId = 0;

            Object.defineProperties(playable, {
                init: {
                    value: function(title, author) {
                        this.title = title;
                        this.author = author;
                        this._id = ++lastId;
                        return this;
                    }
                },
                id: {
                    get: function() {
                        return this._id;
                    }
                },
                title: {
                    get: function() {
                        return this._title;
                    },
                    set: function(value) {
                        validateString(value, 'Title');
                        this._title = value;
                    }
                },
                author: {
                    get: function() {
                        return this._author;
                    },
                    set: function(value) {
                        validateString(value, 'Author');
                        this._author = value;
                    }
                },
                play: {
                    value: function() {
                        return this.id + '. ' + this.title + ' - ' + this.author;
                    }
                }
            });
            return playable;
        }());

        audio = (function(parent) {
            var audio = Object.create(parent);

            Object.defineProperties(audio, {
                init: {
                    value: function(title, author, length) {
                        parent.init.call(this, title, author);
                        this.length = length;
                        return this;
                    }
                },
                length: {
                    get: function() {
                        return this._length;
                    },
                    set: function(value) {
                        validatePositiveNumber(value, 'Length');
                        this._length = value;
                    }
                },
                play: {
                    value: function() {
                        return parent.play.call(this) + ' - ' + this.length;
                    }
                }
            });

            return audio;
        }(playable));

        video = (function(parent) {
            var video = Object.create(parent);

            Object.defineProperties(video, {
                init: {
                    value: function(title, author, imdbRating) {
                        parent.init.call(this, title, author);
                        this.imdbRating = imdbRating;
                        return this;
                    }
                },
                imdbRating: {
                    get: function() {
                        return this._imdbRating;
                    },
                    set: function(value) {
                        validateImdbRating(value, 'Rating');
                        this._imdbRating = value;
                    }
                },
                play: {
                    value: function() {
                        return parent.play.call(this) + ' - ' + this.imdbRating;
                    }
                }
            });

            return video;
        }(playable));

        playlist = (function() {
            var playlist = Object.create({}),
                lastId = 0;

            Object.defineProperties(playlist, {
                init: {
                    value: function(name) {
                        this.name = name;
                        this._id = ++lastId;
                        this._playables = [];
                        return this;
                    }
                },
                name: {
                    get: function() {
                        return this._name;
                    },
                    set: function(value) {
                        validateString(value, 'Name');
                        this._name = value;
                    }
                },
                id: {
                    get: function() {
                        return this._id;
                    }
                },
                addPlayable: {
                    value: function(playable) {
                        validateIfUndefined(playable, 'Playlist add playable parameter');
                        validateIfObject(playable, 'Playlist add playable parameter');
                        validateIfUndefined(playable.id, 'Playlist add playable parameter must have id');

                        this._playables.push(playable);
                        return this;

                    }
                },
                getPlayableById: {
                    value: function(id) {
                        validateIfUndefined(id, 'Playlist get playable parameter id');
                        validateIfNumber(id, 'Playlist get playable paratemeter id');
                        var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                        if (foundIndex < 0) {
                            return null;
                        }
                        return this._playables[foundIndex];
                    }
                },
                removePlayable: {
                    value: function(id) {
                        id = validateId(id);

                        var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                        if (foundIndex < 0) {
                            throw new Error('Playable with id ' + id + ' was not found in playlist');
                        }

                        this._playables.splice(foundIndex, 1);

                        return this;
                    }
                },
                listPlaylables: {
                    value: function(page, size) {
                        validateIfNumber(page);
                        validateIfUndefined(page);
                        validateIfNumber(size);
                        validateIfUndefined(size);
                        if (page < 0 || size <= 0 || page * size > this._playables.length) {
                            throw new Error();
                        }

                        this._playables.sort(function(a, b) {
                            if (a.title === b.title) {
                                return a.id - b.id;
                            }
                            return a.title.localeCompare(b.title);
                        });

                        return this._playables.slice(page * size, (page + 1) * size)
                    }
                },
                getAllPlayables: {
                    value: function() {
                        return this._playables.slice();
                    }
                }
            });

            return playlist;
        }());

        player = (function() {
            function sortByNameThenById(a, b) {
                if (a.name === b.name) {
                    return a.id - b.id;
                }
                return a.name.localeCompare(b.name);
            }

            var player = Object.create({});

            Object.defineProperties(player, {
                init: {
                    value: function(name) {
                        this.name = name;
                        this._playlists = [];
                        return this;
                    }
                },
                name: {
                    get: function() {
                        return this._name;
                    },
                    set: function(value) {
                        validateString(value, 'Name');
                        this._name = value;
                    }
                },
                id: {
                    get: function() {
                        return this._id;
                    }
                },
                addPlaylist: {
                    value: function(playlist) {
                        validateIfUndefined(playlist, 'player add playlist parameter');
                        validateIfObject(playlist, 'player add playlist parameter');
                        validateIfUndefined(playlist.id, 'player add playlist parameter must have id');

                        this._playlists.push(playlist);
                        return this;
                    }
                },
                getPlaylistById: {
                    value: function(id) {
                        validateIfUndefined(id, 'Player get playlist parameter id');
                        validateIfNumber(id, 'Player get playlist paratemeter id');
                        var foundIndex = indexOfElementWithIdInCollection(this._playlists, id);
                        if (foundIndex < 0) {
                            return null;
                        }
                        return this._playlists[foundIndex];
                    }
                },
                removePlaylist: {
                    value: function(id) {
                        id = validateId(id);

                        var foundIndex = indexOfElementWithIdInCollection(this._playlists, id);
                        if (foundIndex < 0) {
                            throw new Error('Playlist with id ' + id + ' was not found in player');
                        }

                        this._playlists.splice(foundIndex, 1);

                        return this;
                    }
                },
                listPlaylists: {
                    value: function(page, size) {
                        validateIfNumber(page);
                        validateIfUndefined(page);
                        validateIfNumber(size);
                        validateIfUndefined(size);
                        if (page < 0 || size <= 0 || page * size > this._playlists.length) {
                            throw new Error();
                        }

                        this._playlists.sort(sortByNameThenById);

                        return this._playlists.slice(page * size, (page + 1) * size)
                    }
                },
                search: {
                    value: function(pattern) {
                        pattern = pattern.toLowerCase();
                        return this._playlists.filter(function(playlist) {
                            return playlist.listPlaylables(0, 10000000000000)
                                .some(function(playable) {
                                    return playable.title.toLowerCase().indexOf(pattern) >= 0;
                                });
                        });
                    }
                },
                contains: {
                    value: function(playable, playlist) {
                        validateIfUndefined(playable);
                        validateIfUndefined(playlist);
                        var playableId = validateId(playable.id);
                        var playlistId = validateId(playlist.id);

                        var playlist = this.getPlaylistById(playlistId);
                        if (playlist == null) {
                            return false;
                        }

                        var playable = playlist.getPlayableById(playableId);
                        if (playable == null) {
                            return false;
                        }

                        return true;
                    }
                }
            });

            return player;
        }());

        return {
            getPlayer: function(name) {
                return Object.create(player).init(name);
            },
            getPlaylist: function(name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function(title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function(title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());

    return module;
}
var module = solve();

player = module.getPlayer('pesho');
playlist = module.getPlaylist('gosho');
player.addPlaylist(playlist);
var audio = module.getAudio('ivan', 'ivanov', 4);
playlist.addPlayable(audio);

console.log(player.search('van'));
