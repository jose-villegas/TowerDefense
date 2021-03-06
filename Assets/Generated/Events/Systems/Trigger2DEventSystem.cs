//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class Trigger2DEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<ITrigger2DListener> _listenerBuffer;

    public Trigger2DEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<ITrigger2DListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.Trigger2D)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasTrigger2D && entity.hasTrigger2DListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.trigger2D;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.trigger2DListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnTrigger2D(e, component.Value);
            }
        }
    }
}
