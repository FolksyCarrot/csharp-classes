Using System;

namespace Classes {

    public class Employees {

          public string name {get; set;} 
          public string position {get; set;}
          public string title {get; set;}
          public DateTime startDate {get; set;}

          public Employees(string fullName, string role) {
              name = fullName;
              position = role;
          }

        }
}