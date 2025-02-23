// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Drive Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DriveItem : BaseItem
    {
    
        /// <summary>
        /// Gets or sets audio.
        /// Audio metadata, if the item is an audio file. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audio", Required = Newtonsoft.Json.Required.Default)]
        public Audio Audio { get; set; }
    
        /// <summary>
        /// Gets or sets bundle.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bundle", Required = Newtonsoft.Json.Required.Default)]
        public Bundle Bundle { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// The content stream, if the item represents a file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets c tag.
        /// An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cTag", Required = Newtonsoft.Json.Required.Default)]
        public string CTag { get; set; }
    
        /// <summary>
        /// Gets or sets deleted.
        /// Information about the deleted state of the item. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deleted", Required = Newtonsoft.Json.Required.Default)]
        public Deleted Deleted { get; set; }
    
        /// <summary>
        /// Gets or sets file.
        /// File metadata, if the item is a file. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "file", Required = Newtonsoft.Json.Required.Default)]
        public File File { get; set; }
    
        /// <summary>
        /// Gets or sets file system info.
        /// File system information on client. Read-write.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileSystemInfo", Required = Newtonsoft.Json.Required.Default)]
        public FileSystemInfo FileSystemInfo { get; set; }
    
        /// <summary>
        /// Gets or sets folder.
        /// Folder metadata, if the item is a folder. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "folder", Required = Newtonsoft.Json.Required.Default)]
        public Folder Folder { get; set; }
    
        /// <summary>
        /// Gets or sets image.
        /// Image metadata, if the item is an image. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "image", Required = Newtonsoft.Json.Required.Default)]
        public Image Image { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// Location metadata, if the item has location data. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public GeoCoordinates Location { get; set; }
    
        /// <summary>
        /// Gets or sets package.
        /// If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "package", Required = Newtonsoft.Json.Required.Default)]
        public Package Package { get; set; }
    
        /// <summary>
        /// Gets or sets pending operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingOperations", Required = Newtonsoft.Json.Required.Default)]
        public PendingOperations PendingOperations { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// Photo metadata, if the item is a photo. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photo", Required = Newtonsoft.Json.Required.Default)]
        public Photo Photo { get; set; }
    
        /// <summary>
        /// Gets or sets publication.
        /// Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publication", Required = Newtonsoft.Json.Required.Default)]
        public PublicationFacet Publication { get; set; }
    
        /// <summary>
        /// Gets or sets remote item.
        /// Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteItem", Required = Newtonsoft.Json.Required.Default)]
        public RemoteItem RemoteItem { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "root", Required = Newtonsoft.Json.Required.Default)]
        public Root Root { get; set; }
    
        /// <summary>
        /// Gets or sets search result.
        /// Search metadata, if the item is from a search result. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "searchResult", Required = Newtonsoft.Json.Required.Default)]
        public SearchResult SearchResult { get; set; }
    
        /// <summary>
        /// Gets or sets shared.
        /// Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shared", Required = Newtonsoft.Json.Required.Default)]
        public Shared Shared { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharepointIds", Required = Newtonsoft.Json.Required.Default)]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// Size of the item in bytes. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "size", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets special folder.
        /// If the current item is also available as a special folder, this facet is returned. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "specialFolder", Required = Newtonsoft.Json.Required.Default)]
        public SpecialFolder SpecialFolder { get; set; }
    
        /// <summary>
        /// Gets or sets video.
        /// Video metadata, if the item is a video. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "video", Required = Newtonsoft.Json.Required.Default)]
        public Video Video { get; set; }
    
        /// <summary>
        /// Gets or sets web dav url.
        /// WebDAV compatible URL for the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webDavUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebDavUrl { get; set; }
    
        /// <summary>
        /// Gets or sets workbook.
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "workbook", Required = Newtonsoft.Json.Required.Default)]
        public Workbook Workbook { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// The list of recent activities that took place on this item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activities", Required = Newtonsoft.Json.Required.Default)]
        public IDriveItemActivitiesCollectionPage Activities { get; set; }
    
        /// <summary>
        /// Gets or sets analytics.
        /// Analytics about the view activities that took place on this item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "analytics", Required = Newtonsoft.Json.Required.Default)]
        public ItemAnalytics Analytics { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "children", Required = Newtonsoft.Json.Required.Default)]
        public IDriveItemChildrenCollectionPage Children { get; set; }
    
        /// <summary>
        /// Gets or sets list item.
        /// For drives in SharePoint, the associated document library list item. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "listItem", Required = Newtonsoft.Json.Required.Default)]
        public ListItem ListItem { get; set; }
    
        /// <summary>
        /// Gets or sets permissions.
        /// The set of permissions for the item. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permissions", Required = Newtonsoft.Json.Required.Default)]
        public IDriveItemPermissionsCollectionPage Permissions { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptions.
        /// The set of subscriptions on the item. Only supported on the root of a drive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptions", Required = Newtonsoft.Json.Required.Default)]
        public IDriveItemSubscriptionsCollectionPage Subscriptions { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnails.
        /// Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "thumbnails", Required = Newtonsoft.Json.Required.Default)]
        public IDriveItemThumbnailsCollectionPage Thumbnails { get; set; }
    
        /// <summary>
        /// Gets or sets versions.
        /// The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "versions", Required = Newtonsoft.Json.Required.Default)]
        public IDriveItemVersionsCollectionPage Versions { get; set; }
    
    }
}

