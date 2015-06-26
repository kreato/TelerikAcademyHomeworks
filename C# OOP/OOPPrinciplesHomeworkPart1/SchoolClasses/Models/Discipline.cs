namespace SchoolClasses.Models
{
    using System;

    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string nameOfDiscipline, int numOfLectures, int numOfExercises)
        {
            this.Name = nameOfDiscipline;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercises = numOfExercises;
        }


        public string Name 
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures 
        { 
            get { return this.numberOfLectures; } 
            private set{this.numberOfLectures = value;}
        }
        
        public int NumberOfExercises 
        {
            get { return this.numberOfExercises; }
            private set { this.numberOfExercises = value; }
        }
        public string Comment { get; set; }
        public string AddComment(string comment)
        {
            return this.Comment = comment;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\r\nNumber of lectures: {1}\r\nNumber of exercises: {2}\r\nComment: {3}\r\n",Name, NumberOfLectures, NumberOfExercises, Comment);
        }
    }
}