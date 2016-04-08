// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class ProtectedItemOperationsExtensions
    {
        /// <summary>
        /// Create Or Update ProtectedItem.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Required. Container Name of protectionContainers
        /// </param>
        /// <param name='protectedItemName'>
        /// Required. Name of ProtectedItem
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        public static BaseRecoveryServicesJobResponse CreateOrUpdateProtectedItem(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, ProtectedItemCreateOrUpdateRequest request, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).CreateOrUpdateProtectedItemAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, request, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create Or Update ProtectedItem.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Required. Container Name of protectionContainers
        /// </param>
        /// <param name='protectedItemName'>
        /// Required. Name of ProtectedItem
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        public static Task<BaseRecoveryServicesJobResponse> CreateOrUpdateProtectedItemAsync(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, ProtectedItemCreateOrUpdateRequest request, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CreateOrUpdateProtectedItemAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, request, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the specified protected item.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Required. Container Name of protectionContainers
        /// </param>
        /// <param name='protectedItemName'>
        /// Required. Name of ProtectedItem
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        public static BaseRecoveryServicesJobResponse DeleteProtectedItem(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).DeleteProtectedItemAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the specified protected item.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Required. Container Name of protectionContainers
        /// </param>
        /// <param name='protectedItemName'>
        /// Required. Name of ProtectedItem
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        public static Task<BaseRecoveryServicesJobResponse> DeleteProtectedItemAsync(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.DeleteProtectedItemAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the details of specific protected Objects.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required.
        /// </param>
        /// <param name='containerName'>
        /// Required.
        /// </param>
        /// <param name='protectedItemName'>
        /// Required.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static ProtectedItemResponse Get(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, GetProtectedItemQueryParam queryFilter, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).GetAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, queryFilter, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the details of specific protected Objects.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required.
        /// </param>
        /// <param name='containerName'>
        /// Required.
        /// </param>
        /// <param name='protectedItemName'>
        /// Required.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static Task<ProtectedItemResponse> GetAsync(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, GetProtectedItemQueryParam queryFilter, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, queryFilter, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get ProtectedObject Operation result by OperationId.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required.
        /// </param>
        /// <param name='containerName'>
        /// Required.
        /// </param>
        /// <param name='protectedItemName'>
        /// Required.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static ProtectedItemResponse GetOperationResult(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).GetOperationResultAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, operationId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get ProtectedObject Operation result by OperationId.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required.
        /// </param>
        /// <param name='containerName'>
        /// Required.
        /// </param>
        /// <param name='protectedItemName'>
        /// Required.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static Task<ProtectedItemResponse> GetOperationResultAsync(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetOperationResultAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, operationId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the operation stauts of specific operationId.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required.
        /// </param>
        /// <param name='containerName'>
        /// Required.
        /// </param>
        /// <param name='protectedItemName'>
        /// Required.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a OperationStatusResponse.
        /// </returns>
        public static BackUpOperationStatusResponse GetOperationStatus(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).GetOperationStatusAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, operationId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the operation stauts of specific operationId.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required.
        /// </param>
        /// <param name='containerName'>
        /// Required.
        /// </param>
        /// <param name='protectedItemName'>
        /// Required.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a OperationStatusResponse.
        /// </returns>
        public static Task<BackUpOperationStatusResponse> GetOperationStatusAsync(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetOperationStatusAsync(resourceGroupName, resourceName, fabricName, containerName, protectedItemName, operationId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the operation stauts of specific URL
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a OperationStatusResponse.
        /// </returns>
        public static BackUpOperationStatusResponse GetOperationStatusByURL(this IProtectedItemOperations operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).GetOperationStatusByURLAsync(operationResultLink, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the operation stauts of specific URL
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a OperationStatusResponse.
        /// </returns>
        public static Task<BackUpOperationStatusResponse> GetOperationStatusByURLAsync(this IProtectedItemOperations operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetOperationStatusByURLAsync(operationResultLink, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get ProtectedObject Operation result by URL.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static ProtectedItemResponse GetProtectedItemOperationResultByURL(this IProtectedItemOperations operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).GetProtectedItemOperationResultByURLAsync(operationResultLink, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get ProtectedObject Operation result by URL.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static Task<ProtectedItemResponse> GetProtectedItemOperationResultByURLAsync(this IProtectedItemOperations operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetProtectedItemOperationResultByURLAsync(operationResultLink, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all protected Objects.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemsListResponse.
        /// </returns>
        public static ProtectedItemListResponse List(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, ProtectedItemListQueryParam queryFilter, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProtectedItemOperations)s).ListAsync(resourceGroupName, resourceName, queryFilter, paginationParams, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all protected Objects.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IProtectedItemOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemsListResponse.
        /// </returns>
        public static Task<ProtectedItemListResponse> ListAsync(this IProtectedItemOperations operations, string resourceGroupName, string resourceName, ProtectedItemListQueryParam queryFilter, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(resourceGroupName, resourceName, queryFilter, paginationParams, customRequestHeaders, CancellationToken.None);
        }
    }
}
