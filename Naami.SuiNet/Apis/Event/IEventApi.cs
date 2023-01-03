﻿using Naami.SuiNet.Apis.Event.Filter;
using Naami.SuiNet.Types;

namespace Naami.SuiNet.Apis.Event;

// marker interface for event filters

public interface IEventApi
{
    public Task<EventPage> GetEvents(bool isDescending = false);
    public Task<EventPage> GetEvents(EventId cursor, uint limit, bool isDescending = false);
    public Task<EventPage> GetEvents<TEventFilter>(TEventFilter query, bool isDescending = false)
        where TEventFilter : IEventFilter;
    public Task<EventPage> GetEvents<TEventFilter>(TEventFilter query, EventId cursor, uint limit, bool isDescending = false)
        where TEventFilter : IEventFilter;
}