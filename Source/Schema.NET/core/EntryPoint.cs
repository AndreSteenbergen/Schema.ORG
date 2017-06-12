namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
    [DataContract]
    public class EntryPoint : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EntryPoint";

        /// <summary>
        /// An application that can complete the request.
        /// </summary>
        [DataMember(Name = "actionApplication", Order = 2)]
        public SoftwareApplication ActionApplication { get; set; }

        /// <summary>
        /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
        /// </summary>
        [DataMember(Name = "actionPlatform", Order = 3)]
        public object ActionPlatform { get; protected set; }

        /// <summary>
        /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
        /// </summary>
        [IgnoreDataMember]
        public Uri ActionPlatformURL
        {
            get => this.ActionPlatform as Uri;
            set => this.ActionPlatform = value;
        }

        /// <summary>
        /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
        /// </summary>
        [IgnoreDataMember]
        public string ActionPlatformText
        {
            get => this.ActionPlatform as string;
            set => this.ActionPlatform = value;
        }

        /// <summary>
        /// The supported content type(s) for an EntryPoint response.
        /// </summary>
        [DataMember(Name = "contentType", Order = 4)]
        public string ContentType { get; set; }

        /// <summary>
        /// The supported encoding type(s) for an EntryPoint request.
        /// </summary>
        [DataMember(Name = "encodingType", Order = 5)]
        public string EncodingType { get; set; }

        /// <summary>
        /// An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
        /// </summary>
        [DataMember(Name = "httpMethod", Order = 6)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// An url template (RFC6570) that will be used to construct the target of the execution of the action.
        /// </summary>
        [DataMember(Name = "urlTemplate", Order = 7)]
        public string UrlTemplate { get; set; }
    }
}