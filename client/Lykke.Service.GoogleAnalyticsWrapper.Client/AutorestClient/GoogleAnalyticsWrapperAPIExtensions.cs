// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.GoogleAnalyticsWrapper.Client.AutorestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GoogleAnalyticsWrapperAPI.
    /// </summary>
    public static partial class GoogleAnalyticsWrapperAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            public static object GetGaUserId(this IGoogleAnalyticsWrapperAPI operations, string clientId)
            {
                return operations.GetGaUserIdAsync(clientId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetGaUserIdAsync(this IGoogleAnalyticsWrapperAPI operations, string clientId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGaUserIdWithHttpMessagesAsync(clientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            public static object GetGaUserTraffic(this IGoogleAnalyticsWrapperAPI operations, string clientId)
            {
                return operations.GetGaUserTrafficAsync(clientId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetGaUserTrafficAsync(this IGoogleAnalyticsWrapperAPI operations, string clientId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGaUserTrafficWithHttpMessagesAsync(clientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ErrorResponse AddGaUserTraffic(this IGoogleAnalyticsWrapperAPI operations, GaTrafficModel model = default(GaTrafficModel))
            {
                return operations.AddGaUserTrafficAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponse> AddGaUserTrafficAsync(this IGoogleAnalyticsWrapperAPI operations, GaTrafficModel model = default(GaTrafficModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddGaUserTrafficWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks service is alive
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object IsAlive(this IGoogleAnalyticsWrapperAPI operations)
            {
                return operations.IsAliveAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks service is alive
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> IsAliveAsync(this IGoogleAnalyticsWrapperAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IsAliveWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ErrorResponse UserRegisteredEvent(this IGoogleAnalyticsWrapperAPI operations, TrackEventModel model = default(TrackEventModel))
            {
                return operations.UserRegisteredEventAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponse> UserRegisteredEventAsync(this IGoogleAnalyticsWrapperAPI operations, TrackEventModel model = default(TrackEventModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UserRegisteredEventWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ErrorResponse KycCompletedEvent(this IGoogleAnalyticsWrapperAPI operations, TrackEventModel model = default(TrackEventModel))
            {
                return operations.KycCompletedEventAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponse> KycCompletedEventAsync(this IGoogleAnalyticsWrapperAPI operations, TrackEventModel model = default(TrackEventModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.KycCompletedEventWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ErrorResponse MtOrderCreatedEvent(this IGoogleAnalyticsWrapperAPI operations, TrackEventModel model = default(TrackEventModel))
            {
                return operations.MtOrderCreatedEventAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponse> MtOrderCreatedEventAsync(this IGoogleAnalyticsWrapperAPI operations, TrackEventModel model = default(TrackEventModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.MtOrderCreatedEventWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ErrorResponse WithdrawDepositEvent(this IGoogleAnalyticsWrapperAPI operations, WithdrawDepositEventModel model = default(WithdrawDepositEventModel))
            {
                return operations.WithdrawDepositEventAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponse> WithdrawDepositEventAsync(this IGoogleAnalyticsWrapperAPI operations, WithdrawDepositEventModel model = default(WithdrawDepositEventModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.WithdrawDepositEventWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ErrorResponse TrackTransaction(this IGoogleAnalyticsWrapperAPI operations, TransactionModel model = default(TransactionModel))
            {
                return operations.TrackTransactionAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponse> TrackTransactionAsync(this IGoogleAnalyticsWrapperAPI operations, TransactionModel model = default(TransactionModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TrackTransactionWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
