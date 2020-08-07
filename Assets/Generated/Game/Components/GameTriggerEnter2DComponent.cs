//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TriggerEnter2DComponent triggerEnter2D { get { return (TriggerEnter2DComponent)GetComponent(GameComponentsLookup.TriggerEnter2D); } }
    public bool hasTriggerEnter2D { get { return HasComponent(GameComponentsLookup.TriggerEnter2D); } }

    public void AddTriggerEnter2D(UnityEngine.Collider2D newValue) {
        var index = GameComponentsLookup.TriggerEnter2D;
        var component = (TriggerEnter2DComponent)CreateComponent(index, typeof(TriggerEnter2DComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTriggerEnter2D(UnityEngine.Collider2D newValue) {
        var index = GameComponentsLookup.TriggerEnter2D;
        var component = (TriggerEnter2DComponent)CreateComponent(index, typeof(TriggerEnter2DComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTriggerEnter2D() {
        RemoveComponent(GameComponentsLookup.TriggerEnter2D);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTriggerEnter2D;

    public static Entitas.IMatcher<GameEntity> TriggerEnter2D {
        get {
            if (_matcherTriggerEnter2D == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TriggerEnter2D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTriggerEnter2D = matcher;
            }

            return _matcherTriggerEnter2D;
        }
    }
}