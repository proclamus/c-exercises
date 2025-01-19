public static List<int> gradingStudents(List<int> grades)
    {
        for(int i=0;i< grades.Count();i++)
        {
            int nextMultiple = ((grades[i]/5)+1)*5;
            
            if(grades[i]<38)
            {
                grades[i] = grades[i];
            }
            else if(nextMultiple - grades[i] < 3)
            {
                grades[i] = nextMultiple;
            }
            else {
                grades[i] = grades[i];
            }
        }
        
        return grades;
    }

    public static List<int> gradingStudents(List<int> grades)
    {
        return grades.Select(grade =>
        {
            if (grade < 38)
                return grade;

            int nextMultipleOfFive = ((grade / 5) + 1) * 5;
            return (nextMultipleOfFive - grade < 3) ? nextMultipleOfFive : grade;
        }).ToList();
    }
