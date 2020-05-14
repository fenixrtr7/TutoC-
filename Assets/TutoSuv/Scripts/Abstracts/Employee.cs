using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{
    public static string companyName = "KO";
    string employeeName;

    public abstract void CalculateMonthlySalary();
}
