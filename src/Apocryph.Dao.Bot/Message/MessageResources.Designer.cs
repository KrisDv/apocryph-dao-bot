﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apocryph.Dao.Bot.Message {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MessageResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessageResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Apocryph.Dao.Bot.Message.MessageResources", typeof(MessageResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Airdrop of {0} CRYPTH completed.
        /// </summary>
        internal static string AirdropConfirmationMessage_OnSuccess {
            get {
                return ResourceManager.GetString("AirdropConfirmationMessage_OnSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Balance: {0} CRYPTH.
        /// </summary>
        internal static string BalanceMessage_OnSuccess {
            get {
                return ResourceManager.GetString("BalanceMessage_OnSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to process your request: {0}.
        /// </summary>
        internal static string GenericMessage_OnFailure {
            get {
                return ResourceManager.GetString("GenericMessage_OnFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hello {0}, please visit {1} to confirm your address.
        /// </summary>
        internal static string IntroChallengeMessage_OnSuccess {
            get {
                return ResourceManager.GetString("IntroChallengeMessage_OnSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Address confirmed.
        /// </summary>
        internal static string IntroConfirmationMessage_OnSuccess {
            get {
                return ResourceManager.GetString("IntroConfirmationMessage_OnSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://scontent-waw1-1.xx.fbcdn.net/v/t1.6435-9/88434866_138538214319337_2977996710908788736_n.jpg?_nc_cat=111&amp;ccb=1-5&amp;_nc_sid=09cbfe&amp;_nc_ohc=VGBh61kPV5oAX8RIdHB&amp;_nc_ht=scontent-waw1-1.xx&amp;oh=00_AT81uNqnTjqIqTnBXdpb7G2y6TmjipaoXY7_19TpBeC4sw&amp;oe=62063A92.
        /// </summary>
        internal static string ProposalEventMessage_GetThumbnailUrl {
            get {
                return ResourceManager.GetString("ProposalEventMessage_GetThumbnailUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vote Proposal {0}:\n {1} {2}.
        /// </summary>
        internal static string ProposalEventMessage_OnSuccess {
            get {
                return ResourceManager.GetString("ProposalEventMessage_OnSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Voting data stored.
        /// </summary>
        internal static string VoteProposalHashMessage_OnSuccess {
            get {
                return ResourceManager.GetString("VoteProposalHashMessage_OnSuccess", resourceCulture);
            }
        }
    }
}
