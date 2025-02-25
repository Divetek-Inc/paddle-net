using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;
using Paddle.Sdk.Entities.Transactions;

namespace Paddle.Sdk.Entities.Events;

public static class EventTypeMapping {
    private static readonly Dictionary<EventType, Type> TypeMap = new() {
        // Subscription events
        { EventType.SubscriptionActivated, typeof(PaddleSubscription) },
        { EventType.SubscriptionCancelled, typeof(PaddleSubscription) },
        { EventType.SubscriptionCreated, typeof(PaddleSubscription) },
        { EventType.SubscriptionImported, typeof(PaddleSubscription) },
        { EventType.SubscriptionPastDue, typeof(PaddleSubscription) },
        { EventType.SubscriptionPaused, typeof(PaddleSubscription) },
        { EventType.SubscriptionResumed, typeof(PaddleSubscription) },
        { EventType.SubscriptionTrialing, typeof(PaddleSubscription) },
        { EventType.SubscriptionUpdated, typeof(PaddleSubscription) },

        // Transaction events
        { EventType.TransactionBilled, typeof(PaddleTransaction) },
        { EventType.TransactionCanceled, typeof(PaddleTransaction) },
        { EventType.TransactionCompleted, typeof(PaddleTransaction) },
        { EventType.TransactionCreated, typeof(PaddleTransaction) },
        { EventType.TransactionPaid, typeof(PaddleTransaction) },
        { EventType.TransactionPastDue, typeof(PaddleTransaction) },
        { EventType.TransactionPaymentFailed, typeof(PaddleTransaction) },
        { EventType.TransactionReady, typeof(PaddleTransaction) },
        { EventType.TransactionUpdated, typeof(PaddleTransaction) },
    };

    public static Type GetDataType(EventType eventType)
        => TypeMap.GetValueOrDefault(eventType, typeof(UnknownEventData));
}