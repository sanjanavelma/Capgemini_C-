using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(HospitalSystem.HospitalName);
        Patient p = new Patient(101, "Sanju", 22);
        p.SetMedicalHistory("Asthma History");
        Doctor d = new Doctor("Dr. Mehta", "Neurologist", 9001);
        Appointment app = new Appointment();
        app.ScheduleAppointment(DateTime.Now, "Online");
        DiagnosisService ds = new DiagnosisService();
        string condition = "Unknown";
        string risk;
        int age = p.Age;
        ds.EvaluatePatient(in age, ref condition, out risk, 80, 75, 60);
        Console.WriteLine($"Condition: {condition}, Risk: {risk}");
        BillingService bill = new BillingService
        {
            ConsultationFee = 500,
            TestCharges = 2000,
            RoomCharges = 4000
        };
        double total = bill.CalculateBill();
        InsuranceService ins = new InsuranceService();
        double final = ins.ApplyInsurance("40", total.ToString());
        Console.WriteLine($"Final Payable Amount: {final}");
    }
}