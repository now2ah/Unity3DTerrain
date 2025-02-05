using System;
using UnityEngine;

[Flags]
public enum Day
{
    NONE = 0,
    SUN = 1 << 0,
    MON = 1 << 1,
    TUE = 1 << 2,
    WED = 1 << 3,
    THU = 1 << 4,
    FRI = 1 << 5,
    SAT = 1 << 6 
}

public enum Job
{
    NONE,
    COMPANYWORKER,
    TAXIDRIVER,
    PROGRAMMER,
    TEACHER
}

public class DataExample : MonoBehaviour
{
    public string[] schedules;
    public Day workDay;
    public Job job;

    private void Start()
    {
        for (int i = 0; i < schedules.Length; i++)
        {
            Debug.Log(schedules[i]);
        }

        Debug.Log(workDay);
        Debug.Log(job);
    }
}
