using System.Collections.Specialized;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [Header("Conditionals")]
    public string Universe;
    public string Align;
    public string Gender;
    public IPerson p;

    [Header("Dropdown")]
    public Dropdown U;
    public Dropdown A;
    public Dropdown G;

    [Header("Logo Image")]
    public Text summon;

    void Update()
    {
        if (U.value == 0)
        {
            Universe = "Marvel";
        }
        else
        {
            Universe = "DC";
        }
        if (A.value == 0)
        {
            Align = "Hero";
        }
        else if (A.value == 1)
        {
            Align = "Villain";
        }
        else
        {
            Align = "Antihero";
        }
        if (G.value == 0)
        {
            Gender = "Female";
        }
        else
        {
            Gender = "Male";
        }
        
        PersonSpecifications specs = new PersonSpecifications();
        specs.alignment = Align;
        specs.universe = Universe;
        specs.gender = Gender;

        IPerson person = GetPerson(specs);
        p = person;
    }

    public void ButtonPress()
    {
        summon.text = p.ToString();
        if (summon.text == "Batman")
        {
            Instantiate(Resources.Load("Batman"));
        }
        else if (summon.text == "BlackFlash")
        {
            Instantiate(Resources.Load("BlackFlash"));
        }
        else if (summon.text == "BlackWidow")
        {
            Instantiate(Resources.Load("BlackWidow"));
        }
        else if (summon.text == "Catwoman")
        {
            Instantiate(Resources.Load("Catwoman"));
        }
        else if (summon.text == "Deadshot")
        {
            Instantiate(Resources.Load("Deadshot"));
        }
        else if (summon.text == "GhostRider")
        {
            Instantiate(Resources.Load("GhostRider"));
        }
        else if (summon.text == "Hulk")
        {
            Instantiate(Resources.Load("Hulk"));
        }
        else if (summon.text == "Loki")
        {
            Instantiate(Resources.Load("Loki"));
        }
        else if (summon.text == "Mystique")
        {
            Instantiate(Resources.Load("Mystique"));
        }
        else if (summon.text == "Nebula")
        {
            Instantiate(Resources.Load("Nebula"));
        }
        else if (summon.text == "PoisonIvy")
        {
            Instantiate(Resources.Load("PoisonIvy"));
        }
        else if (summon.text == "WonderWoman")
        {
            Instantiate(Resources.Load("WonderWoman"));
        }
        else
        {
            Instantiate(Resources.Load("Hela"));
        }

    }

    public static IPerson GetPerson(PersonSpecifications specs)
    {
        PersonFactory factory = new PersonFactory(specs);
        return factory.Create();
    }

}
