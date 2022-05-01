using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ASSIGNMENT SOLUTION

            string assignmentModel1Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.Delete(Path.Combine(assignmentModel1Path, "AssignmentModel1.csv"));
            File.AppendAllText(Path.Combine(assignmentModel1Path, "AssignmentModel1.csv"), "Id,AssignmentName,AssigmentLocation,AssignmentModel2\n");



            var assignmentModel1Object1 = new AssignmentModel1()
            {
                Id = 1,
                AssignmentName = "CSVFileAssignment1",
                AssignmentLocation = "Abuja",
                AssignmentModel2 = new AssignmentModel2
                {
                    Id = 1,
                    AssignmentName = "CSVFileInnerAssignment1",
                    AssignmentLocation = "Abuja",
                    AssignmentModel3 = new AssignmentModel3

                    {
                        Id = 1,
                        AssignmentName = "CSVFileThirdAssignment1",
                        AssignmentLocation = "Abuja"
                    }
                }

            };

            var assignmentModel1Object2 = new AssignmentModel1
            {
                Id = 2,
                AssignmentName = "CSVFileAssignment2",
                AssignmentLocation = "San Francisco",
                AssignmentModel2 = new AssignmentModel2
                {
                    Id = 2,
                    AssignmentName = "CSVFileInnerAssignment2",
                    AssignmentLocation = "San Francisco",
                    AssignmentModel3 = new AssignmentModel3
                    {
                        Id = 2,
                        AssignmentName = "CSVFileThirdAssignment1",
                        AssignmentLocation = "San Francisco",
                    }
                }

            };


            var assignmentModel1Object3 = new AssignmentModel1
            {
                Id = 3,
                AssignmentName = "CSVFileAssignment3",
                AssignmentLocation = "Lagos",
                AssignmentModel2 = new AssignmentModel2
                {
                    Id = 3,
                    AssignmentName = "CSVFileInnerAssignment3",
                    AssignmentLocation = "Lagos",
                    AssignmentModel3 = new AssignmentModel3
                    {
                        Id = 3,
                        AssignmentName = "CSVFileThirdAssignment3",
                        AssignmentLocation = "Lagos",
                    }
                }

            };

            var assignmentModel1Object4 = new AssignmentModel1
            {
                Id = 4,
                AssignmentName = "CSVFileAssignment4",
                AssignmentLocation = "PortHarcourt",
                AssignmentModel2 = new AssignmentModel2
                {
                    Id = 4,
                    AssignmentName = "CSVFileInnerAssignment4",
                    AssignmentLocation = "PortHarcourt",
                    AssignmentModel3 = new AssignmentModel3
                    {
                        Id = 4,
                        AssignmentName = "CSVFileThirdAssignment4",
                        AssignmentLocation = "PortHarcourt",
                    }
                }

            };


            // WRITING TO A CSV FILE
            List<AssignmentModel1> assignmentModel1List = new List<AssignmentModel1>()
            {
                assignmentModel1Object1,
                assignmentModel1Object2,
                assignmentModel1Object3,
                assignmentModel1Object4
            };

            List<string> assignmentModel1StringList = new List<String>();
            foreach (var model in assignmentModel1List)
            {
                string assignmentModelString = "";
                assignmentModelString += $"{model.Id},{model.AssignmentName},{model.AssignmentLocation},{model.AssignmentModel2}";
                assignmentModel1StringList.Add(assignmentModelString);
            }

            Console.WriteLine("CSV File created.");


            File.AppendAllLines(Path.Combine(assignmentModel1Path, "AssignmentModel1.csv"), assignmentModel1StringList);

            // QUESTION 2: READING FROM A CSV FILE

            var assignmentAllLines = File.ReadAllLines(Path.Combine(assignmentModel1Path, "AssignmentModel1.csv"));
            var assignmentModelFromCSVList = new List<AssignmentModel1>();
            foreach (var assignmentModel in assignmentAllLines)
            {
                var assignmentSplit = assignmentModel.Split(",");
                assignmentModelFromCSVList.Add(new AssignmentModel1
                {
                   //  Id = Int32.Parse(assignmentSplit[0]),
                    AssignmentName = assignmentSplit[1],
                    AssignmentLocation = assignmentSplit[2],
                  //  AssignmentModel2 = assignmentSplit[3],
                });

                



            }


        }
    }


    public class AssignmentModel1
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public string AssignmentLocation { get; set; }
        public AssignmentModel2 AssignmentModel2 { get; set; }
    }
    public class AssignmentModel2
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public string AssignmentLocation { get; set; }
        public AssignmentModel3 AssignmentModel3 { get; set; }

        public override string ToString()
        {
            return base.ToString() + $":{AssignmentName}";
        }
    }
    public class AssignmentModel3
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public string AssignmentLocation { get; set; }

    }
}
