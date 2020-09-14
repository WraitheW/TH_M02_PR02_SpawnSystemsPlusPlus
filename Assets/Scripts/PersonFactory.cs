using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPersonFactory
{
    IPerson Create(PersonSpecifications specs);
}

public class HeroFactory : IPersonFactory
{
    public IPerson Create(PersonSpecifications specs)
    {
        if (specs.universe == "Marvel")
        {
            if (specs.gender == "Female")
            {
                return new BlackWidow();
            }
            else
            {
                return new Hulk();
            }
        }
        else
        {
            if (specs.gender == "Female")
            {
                return new WonderWoman();
            }
            else
            {
                return new Batman();
            }
        }
    }
}

public class VillainFactory : IPersonFactory
{
    public IPerson Create(PersonSpecifications specs)
    {
        if (specs.universe == "Marvel")
        {
            if (specs.gender == "Female")
            {
                return new Hela();
            }
            else
            {
                return new Loki();
            }
        }
        else
        {
            if (specs.gender == "Female")
            {
                return new PoisonIvy();
            }
            else
            {
                return new BlackFlash();
            }
        }
    }
}

public class AntiHeroFactory : IPersonFactory
{
    public IPerson Create(PersonSpecifications specs)
    {
        if (specs.universe == "Marvel")
        {
            if (specs.gender == "Female")
            {
                return new Nebula();
            }
            else
            {
                return new GhostRider();
            }
        }
        else
        {
            if (specs.gender == "Female")
            {
                return new Catwoman();
            }
            else
            {
                return new Deadshot();
            }
        }
    }
}

public abstract class AbstractPersonFactory
{
    //public abstract IVillainFactory VillainFactory();
    //public abstract IHeroFactory HeroFactory();

    public abstract IPerson Create();
}

public class PersonFactory : AbstractPersonFactory
{
    private readonly IPersonFactory _factory;
    private readonly PersonSpecifications _specs;

    public PersonFactory(PersonSpecifications specs)
    {
        if (specs.alignment == "Hero")
        {
            _factory = new HeroFactory();
        }
        else if (specs.alignment == "Villain")
        {
            _factory = new VillainFactory();
        }
        else
        {
            _factory = new AntiHeroFactory();
        }
        _specs = specs;
    }

    public override IPerson Create()
    {
        return _factory.Create(_specs);
    }
}