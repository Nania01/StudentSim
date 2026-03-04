using UnityEngine;

[CreateAssetMenu(fileName = "NewStudentData", menuName = "Game/Student Data")]
public class StudentData : ScriptableObject
{
    [Header("Основные характеристики")]
    public string studentName = "Студент";
    public int money = 1000;
    public int health = 100;
    public int hunger = 100;
    public int moralState = 100;

    [Header("Прогресс обучения")]
    public int knowledge = 0;
    public int currentWeek = 1;
    public int currentSemester = 1;
}
