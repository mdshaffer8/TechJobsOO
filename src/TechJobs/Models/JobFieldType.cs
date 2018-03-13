//This class is an enum that enables the view and controller layers to easily ask for data 
// related to a specific job field, or to all fields.

//Many of the methods in JobData now work by taking in a JobFieldType parameter rather than a string.

//We also use the JobFieldType values to render search and list options in the view, and to collect these 
// options in the ViewModel and controller layers.

using System.ComponentModel.DataAnnotations;

namespace TechJobs.Models
{
    public enum JobFieldType
    {
        // Enum representing the JobField properties of a Job
        // that can be viewed and searched.

        Employer,
        Location,
        CoreCompetency,
        PositionType,
        All
    }
}
