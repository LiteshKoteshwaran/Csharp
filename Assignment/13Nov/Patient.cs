using System;
using System.Collections.Generic;
using System.Text;

namespace _13Nov
{
    class Patient : Person
    {
        string PatientName, PatientContactNo, PatientProfession, DoctorAssigned;
        int PatientID;
        string[] PatientSymtomps;

        public void EntryPatientDetails()
        {
            EnterPersonDetails();
        }
    }
}
