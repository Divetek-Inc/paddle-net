using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;
using Paddle.Sdk.Entities.Transactions;

namespace Paddle.Sdk.Entities.Events;

public static class EventTypeMapping {
    private static readonly Dictionary<EventType, Type> TypeMap = new() {
        // Subscription events
        { EventType.SubscriptionActivated, typeof(Subscription) },
        { EventType.SubscriptionCancelled, typeof(Subscription) },
        { EventType.SubscriptionCreated, typeof(Subscription) },
        { EventType.SubscriptionImported, typeof(Subscription) },
        { EventType.SubscriptionPastDue, typeof(Subscription) },
        { EventType.SubscriptionPaused, typeof(Subscription) },
        { EventType.SubscriptionResumed, typeof(Subscription) },
        { EventType.SubscriptionTrialing, typeof(Subscription) },
        { EventType.SubscriptionUpdated, typeof(Subscription) },

        // Transaction events
        { EventType.TransactionBilled, typeof(Transaction) },
        { EventType.TransactionCanceled, typeof(Transaction) },
        { EventType.TransactionCompleted, typeof(Transaction) },
        { EventType.TransactionCreated, typeof(Transaction) },
        { EventType.TransactionPaid, typeof(Transaction) },
        { EventType.TransactionPastDue, typeof(Transaction) },
        { EventType.TransactionPaymentFailed, typeof(Transaction) },
        { EventType.TransactionReady, typeof(Transaction) },
        { EventType.TransactionUpdated, typeof(Transaction) },
    };

    public static Type GetDataType(EventType eventType)
        => TypeMap.GetValueOrDefault(eventType, typeof(UnknownEventData));
}