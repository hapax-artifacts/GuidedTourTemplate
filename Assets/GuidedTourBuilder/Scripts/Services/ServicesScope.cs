using UnityEngine;
using UnityEngine.Playables;
using VContainer;
using VContainer.Unity;

public class ServicesScope : LifetimeScope
{
    [SerializeField] private PlayableDirector playableDirector;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(playableDirector);


    }
}
