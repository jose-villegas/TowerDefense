﻿using Pipe;

public sealed class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        // player
        Add(new PlayerSpawnSystem(contexts));
        Add(new PlayerMovementSystem(contexts));

        // environment
        Add(new PipeSpawnSystem(contexts));
        Add(new PipeMovementSystem(contexts));

        // view
        Add(new SyncPositionSystem(contexts));
        Add(new ViewSystem(contexts));

        // events
        Add(new GameEventSystems(contexts));
        
        // input
        Add(new InputSystem(contexts));
    }
}