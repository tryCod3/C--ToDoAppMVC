using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace DBconfig.Models
{
    public class Todo
    {
        [Required , DisplayName("Id")]
        public string Id { get; set; }

        [Required, DisplayName("Work")]
        public string Work { get; set; }

        public string Date { get; } = DateTime.Now.ToString("MM/dd/yyyy HH:mm");

        [Required, DisplayName("Status")]
        public bool Status { get; set; } = false;

        public Todo()
        {
            Id = "";
            Work = "";
            Status = false;
        }
        public Todo(string id, string work, bool status)
        {
            Id = id;
            Work = work;
            Status = status;
        }

        public override bool Equals(object obj)
        {
            return obj is Todo todo &&
                   Id.Equals(todo.Id) &&
                   Work.Equals(todo.Work) &&
                   Date.Equals(todo.Date) &&
                   Status == todo.Status &&
                   obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            int hashCode = -1966402320;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Work);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Date);
            hashCode = hashCode * -1521134295 + Status.GetHashCode();
            return hashCode;
        }

    }
}
