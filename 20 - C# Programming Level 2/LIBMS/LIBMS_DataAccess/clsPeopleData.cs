using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBMS_DataAccess
{
    public class clsPeopleData
    {
        static clsGenericDataAccessMethods GenericMethods = new clsGenericDataAccessMethods();
        
        public static DataTable GetAllPeople()
        {
            DataTable dtPeopleData = GenericMethods.ExecuteGetData("SP_GetAllPeople");

            return dtPeopleData;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
        string Email, string Phone, DateTime DateOfBirth, int Gendor, string Address, int CountryID, string ImagePath)
        {
            SqlParameter[] ParameterList = new SqlParameter[12];

            ParameterList[0] = new SqlParameter("@NationalNo", NationalNo);
            ParameterList[1] = new SqlParameter("@FirstName", FirstName);
            ParameterList[2] = new SqlParameter("@SecondName", SecondName);
            ParameterList[3] = new SqlParameter("@ThirdName", ThirdName);
            ParameterList[4] = new SqlParameter("@LastName", LastName);
            ParameterList[5] = new SqlParameter("@Email", (string.IsNullOrEmpty(Email))?(object)DBNull.Value : Email);
            ParameterList[6] = new SqlParameter("@Phone", Phone);
            ParameterList[7] = new SqlParameter("@DateOfBirth", DateOfBirth);
            ParameterList[8] = new SqlParameter("@Gendor", Gendor);
            ParameterList[9] = new SqlParameter("@Address", Address);
            ParameterList[10] = new SqlParameter("@CountryID", CountryID);
            ParameterList[11] = new SqlParameter("@ImagePath", (string.IsNullOrEmpty(ImagePath)) ? (object)DBNull.Value : ImagePath);

            return GenericMethods.ExecuteInsert("SP_AddNewPerson", ParameterList);

        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
        string Email, string Phone, DateTime DateOfBirth, int Gendor, string Address, int CountryID, string ImagePath)
        {
            SqlParameter[] ParameterList = new SqlParameter[13];

            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            ParameterList[1] = new SqlParameter("@NationalNo", NationalNo);
            ParameterList[2] = new SqlParameter("@FirstName", FirstName);
            ParameterList[3] = new SqlParameter("@SecondName", SecondName);
            ParameterList[4] = new SqlParameter("@ThirdName", ThirdName);
            ParameterList[5] = new SqlParameter("@LastName", LastName);
            ParameterList[6] = new SqlParameter("@Email", (string.IsNullOrEmpty(Email)) ? (object)DBNull.Value : Email);
            ParameterList[7] = new SqlParameter("@Phone", Phone);
            ParameterList[8] = new SqlParameter("@DateOfBirth", DateOfBirth);
            ParameterList[9] = new SqlParameter("@Gendor", Gendor);
            ParameterList[10] = new SqlParameter("@Address", Address);
            ParameterList[11] = new SqlParameter("@CountryID", CountryID);
            ParameterList[12] = new SqlParameter("@ImagePath", (string.IsNullOrEmpty(ImagePath)) ? (object)DBNull.Value : ImagePath);

            return GenericMethods.ExecuteUpdate("SP_UpdatePerson", ParameterList);
        }

        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
        ref string Email, ref string Phone, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref int CountryID,
        ref string ImagePath)
        {
            bool isFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            DataTable dtPersonDataByID = GenericMethods.ExecuteGetData("SP_GetPersonInfoByID", ParameterList);

            if(dtPersonDataByID.Rows.Count > 0)
            {
                DataRow row = dtPersonDataByID.Rows[0];

                NationalNo = (string)row["NationalNo"];

                FirstName = (string)row["FirstName"];
                SecondName = (string)row["SecondName"];
                if (row["ThirdName"] != DBNull.Value)
                {
                    ThirdName = (string)row["ThirdName"];
                }
                else
                {
                    ThirdName = "";
                }
                LastName = (string)row["LastName"];
                DateOfBirth = (DateTime)row["DateOfBirth"];
                Gendor = (byte)row["Gendor"];
                if (row["Email"] != DBNull.Value)
                {
                    Email = (string)row["Email"];
                }
                else
                {
                    Email = "";
                }
                Phone = (string)row["Phone"];
                Address = (string)row["Address"];
                CountryID = (int)row["CountryID"];
                if (row["ImagePath"] != DBNull.Value)
                {
                    ImagePath = (string)row["ImagePath"];
                }
                else
                {
                    ImagePath = "";
                }
                isFound = true;
            }else
            {
                isFound = false;
            }
            return isFound;
        }

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
        ref string Email, ref string Phone, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref int CountryID,
        ref string ImagePath)
        {
            bool isFound = false;
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@NationalNo", NationalNo);
            DataTable dtPersonDataByID = GenericMethods.ExecuteGetData("SP_GetPersonInfoByNationalNo", ParameterList);

            if (dtPersonDataByID.Rows.Count > 0)
            {
                DataRow row = dtPersonDataByID.Rows[0];

                PersonID = (int)row["PersonID"];

                FirstName = (string)row["FirstName"];
                SecondName = (string)row["SecondName"];
                if (row["ThirdName"] != DBNull.Value)
                {
                    ThirdName = (string)row["ThirdName"];
                }
                else
                {
                    ThirdName = "";
                }
                LastName = (string)row["LastName"];
                DateOfBirth = (DateTime)row["DateOfBirth"];
                Gendor = (byte)row["Gendor"];
                if (row["Email"] != DBNull.Value)
                {
                    Email = (string)row["Email"];
                }
                else
                {
                    Email = "";
                }
                Phone = (string)row["Phone"];
                Address = (string)row["Address"];
                CountryID = (int)row["CountryID"];
                if (row["ImagePath"] != DBNull.Value)
                {
                    ImagePath = (string)row["ImagePath"];
                }
                else
                {
                    ImagePath = "";
                }
                isFound = true;
            }
            else
            {
                isFound = false;
            }
            return isFound;
        }

        public static bool DeletePerson(int PersonID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@PersonID", PersonID);
            return GenericMethods.ExecuteDelete("SP_DeletePerson", ParameterList);
        }

        public static bool IsPersonExist(int PersonID)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@PersonID", PersonID);

            return GenericMethods.IsRecordExists("SP_IsPersonExisByPersonID", ParameterList);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            SqlParameter[] ParameterList = new SqlParameter[1];
            ParameterList[0] = new SqlParameter("@NationalNo", NationalNo);

            return GenericMethods.IsRecordExists("SP_IsPersonExisByNationalNo", ParameterList);
        }

    }
}
