/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */

/* Example
var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');
var head = Object.create(domElement)
    .init('head')
    .appendChild(meta)
var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');
div.content = 'Hello, world!';
var body = Object.create(domElement)
    .init('body')
    .appendChild(div)
    .addAttribute('id', 'cuki')
    .addAttribute('bgcolor', '#012345');
var root = Object.create(domElement)
    .init('html')
    .appendChild(head)
    .appendChild(body);
console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/

function solve() {

  var domElement = (function() {

    var domElement = {};

    function validateName(name, regEx) {
      if (name === undefined || typeof name !== 'string' || name === '') {
        return false;
      }

      regEx = regEx || /[^A-Za-z\d-]/;
      if (regEx.exec(name)) {
        return false;
      }

      return true;
    }

    function hasNoChildren(domElement) {
      if (domElement.children.length === 0) {
        return true;
      } else {
        return false;
      }
    }

    function sortAttributesByName(previousAttribute, currentAttribute) {
      if (previousAttribute.name > currentAttribute.name) {
        return 1;
      }

      if (previousAttribute.name < currentAttribute.name) {
        return -1;
      }

      return 0;
    }

    Object.defineProperties(domElement, {
      init: {
        value: function(type) {
          this.type = type;
          this._children = [];
          this._attributes = [];
          return this;
        }
      },
      appendChild: {
        value: function(child) {
          if (typeof child === 'object' && Object.getPrototypeOf(child) === domElement) {
            child._parent = this;
            this._children.push(child);
          } else if (typeof child === 'string' && child !== '') {
            this._children.push(child);
          } else {
            throw 'Invalid child';
          }

          return this;
        }
      },
      addAttribute: {
        value: function(name, value) {
          var isFound,
            attributeToPush,
            self;

          if (!validateName(name, /[^A-Za-z\d-]/)) {
            throw 'Invalid attribute name!';
          }

          attributeToPush = {
            name: name,
            value: value
          };
          isFound = this._attributes.some(
            function(attribute, index) {
              if (attribute.name === name) {
                attribute.value = value;
                return true;
              }

              return false;
            });
          if (!isFound) {
            this._attributes.push(attributeToPush);
          }

          return this;
        }
      },
      removeAttribute: {
        value: function(name) {
          var notFound;

          if (!validateName(name)) {
            throw 'Invalid attribute name. Cannot remove!';
          }

          notFound = true;
          this._attributes = this._attributes.filter(
            function(attribute) {
              if (attribute.name === name) {
                notFound = false;
                return false;
              }

              return true;
            });

          if (notFound) {
            throw 'Attribute does not exist!';
          }

          return this;
        }
      },
      innerHTML: {
        get: function() {
          var result = '<' + this.type,
            child,
            attribute,
            attributesLength = this._attributes.length,
            i;

          this._attributes = this._attributes.sort(sortAttributesByName);
          for (i = 0; i < attributesLength; i += 1) {
            attribute = this._attributes[i];
            result += ' ' + attribute.name + '="' + attribute.value + '"';
          }

          result += '>';

          this.children.forEach(function(child) {
            if (typeof child === 'string') {
              result += child;
            } else {
              result += child.innerHTML;
            }
          });

          if (hasNoChildren(this)) {
            result += this.content;
          }

          result += '</' + this.type + '>';
          return result;
        }
      },
      type: {
        get: function() {
          return this._type;
        },
        set: function(value) {
          if (validateName(value, /[^A-Za-z\d]/)) {
            this._type = value;
          } else {
            throw 'Invalid type';
          }
        }
      },
      content: {
        get: function() {
          return this._content || '';
        },
        set: function(value) {
          this._content = value;
        }
      },
      parent: {
        get: function() {
          return this._parent;
        },
        set: function(parent) {
          if (typeof parent === 'object' &&
            Object.getPrototypeOf(parent) === domElement) {
            // this._parent = parent;
            parent.appendChild(this);
          } else {
            throw 'Parent must be of type domElement!';
          }
        }
      },
      children: {
        get: function() {
          return this._children.slice();
        }
      },
      attributes: {
        get: function() {
          return this._attributes.slice();
        }
      }
    });

    return domElement;
  }());

  return domElement;
}

module.exports = solve;
