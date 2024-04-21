using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Users can control what user-generated content they want to see under the
    /// <b>Mature Content Filtering</b> section in their preferences. This filtering is done
    /// automatically by Steam servers, but first, user-generated content must be tagged appropriately.
    /// Developers can use
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddContentDescriptor" class="bb_apilink">ISteamUGC::AddContentDescriptor</a>
    /// and
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveContentDescriptor" class="bb_apilink">ISteamUGC::RemoveContentDescriptor</a>
    /// calls to manage content descriptors a piece of UGC has. These can be retrieved from the result of a
    /// query via
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCContentDescriptors" class="bb_apilink">ISteamUGC::GetQueryUGCContentDescriptors</a>. <br />
    /// <br />
    /// 
    /// </summary>
    public enum UGCContentDescriptorID : int
    {
        /// <summary>
        ///             Some Nudity or Sexual Content:<br />
        ///             Contains content that has some nudity or sexual themes, but not as the primary focus.
        ///         </summary>
        UGCContentDescriptor_NudityOrSexualContent = 1,
        /// <summary>
        ///             Frequent Violence or Gore:<br />
        ///             Contains content that features extreme violence or gore.
        ///         </summary>
        UGCContentDescriptor_FrequentViolenceOrGore = 2,
        /// <summary>
        ///             Adult Only Sexual Content: <br />
        ///             Contains content that is sexually explicit or graphic and is intended for adults only.
        ///             Users must affirm that they are at least eighteen years old before they can view content
        ///             with this content descriptor.
        ///         </summary>
        UGCContentDescriptor_AdultOnlySexualContent = 3,
        /// <summary>
        ///             Frequent Nudity or Sexual Content:<br />
        ///             Contains content that primarily features nudity or sexual themes. Users must affirm that
        ///             they are at least eighteen years old before they can view content with this content
        ///             descriptor.
        ///         </summary>
        UGCContentDescriptor_GratuitousSexualContent = 4,
        /// <summary>
        ///             General Mature Content:<br />
        ///             Contains mature topics that may not be appropriate for all audiences.
        ///         </summary>
        UGCContentDescriptor_AnyMatureContent = 5
    }
}