using BOL;
using DAL.Connected;

namespace BLL;
    public class HrManager
    {


    public List<Hr> getAllHrRecords()
    {
        List<Hr> getAllRecords =  new List<Hr> ();

        getAllRecords = DbManager.GetAllHr();

        return getAllRecords;
    }






    }

