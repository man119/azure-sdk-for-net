// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class FeaturesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<FeatureResult> ListAll(this IFeaturesOperations operations)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FeatureResult>> ListAllAsync( this IFeaturesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            public static IPage<FeatureResult> List(this IFeaturesOperations operations, string resourceProviderNamespace)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListAsync(resourceProviderNamespace), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FeatureResult>> ListAsync( this IFeaturesOperations operations, string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all features under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            public static FeatureResult Get(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).GetAsync(resourceProviderNamespace, featureName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all features under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeatureResult> GetAsync( this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, featureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Registers for a previewed feature of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            public static FeatureResult Register(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).RegisterAsync(resourceProviderNamespace, featureName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers for a previewed feature of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeatureResult> RegisterAsync( this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegisterWithHttpMessagesAsync(resourceProviderNamespace, featureName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FeatureResult> ListAllNext(this IFeaturesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FeatureResult>> ListAllNextAsync( this IFeaturesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FeatureResult> ListNext(this IFeaturesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FeatureResult>> ListNextAsync( this IFeaturesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
