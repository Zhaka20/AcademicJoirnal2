using AcademicJournal.AbstractBLL.AbstractServices.Common;
using AcademicJournal.DataModel.Models;
using AcademicJournal.FrontToBLL_DTOs.DTOs;

namespace AcademicJournal.AbstractBLL.AbstractServices
{
    public interface ISubmissionService 
    {
        void DeleteFileFromFSandDBIfExists(SubmitFileDTO submitFile);
    }
}
