namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Teacher : People, IComment
    {
        private IList<Discipline> setOfDisciplines;
        private IList<string> comments;

        public Teacher(string name, params Discipline[] newDiscipline)
        {
            this.Name = name;
            this.setOfDisciplines = newDiscipline;
            this.comments = new List<string>();
        }

        public string SetOfDisciplines
        {
            get
            {
                return string.Join(", ", this.setOfDisciplines.Select(dsp => dsp.DisciplineName));
            }
        }

        public string GetComments
        {
            get
            {
                return string.Join("/ ", this.comments);
            }
        }

        public void AddComment(string input)
        {
            this.comments.Add(input);
        }
    }
}
