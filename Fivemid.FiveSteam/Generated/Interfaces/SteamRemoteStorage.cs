using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamRemoteStorage
    {
        public static ISteamRemoteStorage.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamRemoteStorage_v016", CallingConvention = Platform.CC)]
        private static extern ISteamRemoteStorage.Instance Accessor();
        /// <summary><code>bool FileWrite( const char *pchFile, const void *pvData, int32 cubData );</code><br />
        /// Creates a new file, writes the bytes to the file, and then closes the file. If the target file already exists, it is overwritten.<br />
        /// <br />
        /// <b>NOTE:</b> This is a synchronous call and as such is a will block your calling thread on the disk IO, and will also block the SteamAPI, which can cause other threads in your application to block. To avoid "hitching" due to a busy disk on the client machine using <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteAsync" class="bb_apilink">ISteamRemoteStorage::FileWriteAsync</a>, the asynchronous version of this API is recommended.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the write was successful.<br />
        /// <br />
        /// Otherwise, <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> The file you're trying to write is larger than 100MiB as defined by <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_unMaxCloudFileChunkSize" class="bb_apilink">k_unMaxCloudFileChunkSize</a>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">cubData</code> is less than <b>0</b>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pvData</code> is <b>NULL</b>.<br />
        /// 	</li><li> You tried to write to an invalid path or filename. Because Steam Cloud is cross platform the files need to have valid names on all supported OSes and file systems. See Microsoft's documentation on <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365247(v=vs.85).aspx" target="_blank" rel="noreferrer">Naming Files, Paths, and Namespaces</a>.<br />
        /// 	</li><li> The current user's Steam Cloud storage quota has been exceeded. They may have run out of space, or have too many files.<br />
        /// 	</li><li> Steam could not write to the disk, the location might be read-only.</li></ul></summary>
        /// <param name="pchFile">const char *: The name of the file to write to.</param>
        /// <param name="pvData">const void *: The bytes to write to the file.</param>
        /// <param name="cubData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>: The number of bytes to write to the file. Typically the total size of <code class="bb_code bb_code_inline nohighlight">pvData</code>.</param>
        public static bool FileWrite(UTF8StringPtr pchFile, void* pvData, int cubData) => Instance.FileWrite(pchFile, pvData, cubData);
        /// <summary><code>int32 FileRead( const char *pchFile, void *pvData, int32 cubDataToRead );</code><br />
        /// Opens a binary file, reads the contents of the file into a byte array, and then closes the file.<br />
        /// <br />
        /// <b>NOTE:</b> This is a synchronous call and as such is a will block your calling thread on the disk IO, and will also block the SteamAPI, which can cause other threads in your application to block. To avoid "hitching" due to a busy disk on the client machine using <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileReadAsync" class="bb_apilink">ISteamRemoteStorage::FileReadAsync</a>, the asynchronous version of this API is recommended.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a><br />
        /// The number of bytes read.<br />
        /// <br />
        /// Returns <b>0</b> if the file doesn't exist or the read fails.</summary>
        /// <param name="pchFile">const char *: The name of the file to read from.</param>
        /// <param name="pvData">void *: The buffer that the file will be read into. This buffer must be at least the same size provided to <code class="bb_code bb_code_inline nohighlight">cubDataToRead</code>.</param>
        /// <param name="cubDataToRead"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>: The amount of bytes to read. Generally obtained from <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetFileSize" class="bb_apilink">ISteamRemoteStorage::GetFileSize</a> or <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetFileTimestamp" class="bb_apilink">ISteamRemoteStorage::GetFileTimestamp</a>.</param>
        public static int FileRead(UTF8StringPtr pchFile, void* pvData, int cubDataToRead) => Instance.FileRead(pchFile, pvData, cubDataToRead);
        /// <summary><code>SteamAPICall_t FileWriteAsync( const char *pchFile, const void *pvData, uint32 cubData );</code><br />
        /// Creates a new file and asynchronously writes the raw byte data to the Steam Cloud, and then closes the file. If the target file already exists, it is overwritten.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageFileWriteAsyncComplete_t" class="bb_apilink">RemoteStorageFileWriteAsyncComplete_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> The file you're trying to write is larger than 100MiB as defined by <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_unMaxCloudFileChunkSize" class="bb_apilink">k_unMaxCloudFileChunkSize</a>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">cubData</code> is less than <b>0</b>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pvData</code> is <b>NULL</b>.<br />
        /// 	</li><li> You tried to write to an invalid path or filename. Because Steam Cloud is cross platform the files need to have valid names on all supported OSes and file systems. See Microsoft's documentation on <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365247(v=vs.85).aspx" target="_blank" rel="noreferrer">Naming Files, Paths, and Namespaces</a>.<br />
        /// 	</li><li> The current user's Steam Cloud storage quota has been exceeded. They may have run out of space, or have too many files.</li></ul></summary>
        /// <param name="pchFile">const char *: The name of the file to write to.</param>
        /// <param name="pvData">const void *: The bytes to write to the file.</param>
        /// <param name="cubData"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of bytes to write to the file. Typically the total size of <code class="bb_code bb_code_inline nohighlight">pvData</code>.</param>
        public static SteamAPICall FileWriteAsync(UTF8StringPtr pchFile, void* pvData, uint cubData) => Instance.FileWriteAsync(pchFile, pvData, cubData);
        /// <summary><code>SteamAPICall_t FileReadAsync( const char *pchFile, uint32 nOffset, uint32 cubToRead );</code><br />
        /// Starts an asynchronous read from a file.<br />
        /// <br />
        /// The offset and amount to read should be valid for the size of the file, as indicated by <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetFileSize" class="bb_apilink">ISteamRemoteStorage::GetFileSize</a> or <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetFileTimestamp" class="bb_apilink">ISteamRemoteStorage::GetFileTimestamp</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageFileReadAsyncComplete_t" class="bb_apilink">RemoteStorageFileReadAsyncComplete_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> You tried to read from invalid path or filename. Because Steam Cloud is cross platform the files need to have valid names on all supported OSes and file systems. See Microsoft's documentation on <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365247(v=vs.85).aspx" target="_blank" rel="noreferrer">Naming Files, Paths, and Namespaces</a>.<br />
        /// 	</li><li> The file doesn't exist.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">cubDataToRead</code> is &lt;= 0 bytes. You need to be able to read something!<br />
        /// 	</li><li> The combination of <code class="bb_code bb_code_inline nohighlight">pvData</code> and <code class="bb_code bb_code_inline nohighlight">cubDataToRead</code> would read past the end of the file.<br />
        /// 	</li><li> You have an async read in progress on this file already.</li></ul><br />
        /// Upon completion of the read request you will receive the call result, if the value of <code class="bb_code bb_code_inline nohighlight">m_eResult</code> within the call result is <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> you can then call <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileReadAsyncComplete" class="bb_apilink">ISteamRemoteStorage::FileReadAsyncComplete</a> to read the requested data into your buffer. The <code class="bb_code bb_code_inline nohighlight">hReadCall</code> parameter should match the return value of this function, and the amount to read should generally be equal to the amount requested as indicated by <code class="bb_code bb_code_inline nohighlight">m_nOffset</code> and <code class="bb_code bb_code_inline nohighlight">m_cubRead</code>.</summary>
        /// <param name="pchFile">const char *: The name of the file to read from.</param>
        /// <param name="nOffset"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The offset in bytes into the file where the read will start from. <b>0</b> if you're reading the whole file in one chunk.</param>
        /// <param name="cubToRead"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The amount of bytes to read starting from <code class="bb_code bb_code_inline nohighlight">nOffset</code>.</param>
        public static SteamAPICall FileReadAsync(UTF8StringPtr pchFile, uint nOffset, uint cubToRead) => Instance.FileReadAsync(pchFile, nOffset, cubToRead);
        /// <summary><code>bool FileReadAsyncComplete( SteamAPICall_t hReadCall, void *pvBuffer, uint32 cubToRead );</code><br />
        /// Copies the bytes from a file which was asynchronously read with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileReadAsync" class="bb_apilink">ISteamRemoteStorage::FileReadAsync</a> into a byte array.<br />
        /// <br />
        /// This should never be called outside of the context of a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageFileReadAsyncComplete_t" class="bb_apilink">RemoteStorageFileReadAsyncComplete_t</a> call result.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the file was successfully read.<br />
        /// <br />
        /// Otherwise, <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> The handle passed to <code class="bb_code bb_code_inline nohighlight">hReadCall</code> is invalid.<br />
        /// 	</li><li> The read failed as indicated by <code class="bb_code bb_code_inline nohighlight">m_eResult</code> in <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageFileReadAsyncComplete_t" class="bb_apilink">RemoteStorageFileReadAsyncComplete_t</a>, you shouldn't have called this.<br />
        /// 	</li><li> The buffer provided to <code class="bb_code bb_code_inline nohighlight">pvBuffer</code> isn't big enough.</li></ul></summary>
        /// <param name="hReadCall"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>: The call result handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageFileReadAsyncComplete_t" class="bb_apilink">RemoteStorageFileReadAsyncComplete_t</a>.</param>
        /// <param name="pvBuffer">void *: The buffer that the file will be read into.</param>
        /// <param name="cubToRead"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of bytes to copy. This should usually be the <code class="bb_code bb_code_inline nohighlight">m_cubRead</code> value from <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageFileReadAsyncComplete_t" class="bb_apilink">RemoteStorageFileReadAsyncComplete_t</a></param>
        public static bool FileReadAsyncComplete(SteamAPICall hReadCall, void* pvBuffer, uint cubToRead) => Instance.FileReadAsyncComplete(hReadCall, pvBuffer, cubToRead);
        /// <summary><code>bool FileForget( const char *pchFile );</code><br />
        /// Deletes the file from remote storage, but leaves it on the local disk and remains accessible from the API.<br />
        /// <br />
        /// When you are out of Cloud space, this can be used to allow calls to <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWrite" class="bb_apilink">ISteamRemoteStorage::FileWrite</a> to keep working without needing to make the user delete files.<br />
        /// <br />
        /// How you decide which files to forget are up to you. It could be a simple Least Recently Used (LRU) queue or something more complicated.<br />
        /// <br />
        /// Requiring the user to manage their Cloud-ized files for a game, while is possible to do, it is never recommended. For instance, "Which file would you like to delete so that you may store this new one?" removes a significant advantage of using the Cloud in the first place: its transparency.<br />
        /// <br />
        /// Once a file has been deleted or forgotten, calling <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWrite" class="bb_apilink">ISteamRemoteStorage::FileWrite</a> will resynchronize it in the Cloud. Rewriting a forgotten file is the only way to make it persisted again.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the file exists and has been successfully forgotten; otherwise, <b>false</b>.</summary>
        /// <param name="pchFile">const char *: The name of the file that will be forgotten.</param>
        public static bool FileForget(UTF8StringPtr pchFile) => Instance.FileForget(pchFile);
        /// <summary><code>bool FileDelete( const char *pchFile );</code><br />
        /// Deletes a file from the local disk, and propagates that delete to the cloud.<br />
        /// <br />
        /// This is meant to be used when a user actively deletes a file. Use <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileForget" class="bb_apilink">ISteamRemoteStorage::FileForget</a> if you want to remove a file from the Steam Cloud but retain it on the users local disk.<br />
        /// <br />
        /// When a file has been deleted it can be re-written with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWrite" class="bb_apilink">ISteamRemoteStorage::FileWrite</a> to reupload it to the Steam Cloud.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the file exists and has been successfully deleted; otherwise, <b>false</b> if the file did not exist.</summary>
        /// <param name="pchFile">const char *: The name of the file that will be deleted.</param>
        public static bool FileDelete(UTF8StringPtr pchFile) => Instance.FileDelete(pchFile);
        /// <summary><code>SteamAPICall_t FileShare( const char *pchFile );</code><br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageFileShareResult_t" class="bb_apilink">RemoteStorageFileShareResult_t</a> call result.</summary>
        /// <param name="pchFile">const char *: </param>
        public static SteamAPICall FileShare(UTF8StringPtr pchFile) => Instance.FileShare(pchFile);
        /// <summary><code>bool SetSyncPlatforms( const char *pchFile, ERemoteStoragePlatform eRemoteStoragePlatform );</code><br />
        /// Allows you to specify which operating systems a file will be synchronized to.<br />
        /// <br />
        /// Use this if you have a multiplatform game but have data which is incompatible between platforms.<br />
        /// <br />
        /// Files default to <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_ERemoteStoragePlatformAll" class="bb_apilink">k_ERemoteStoragePlatformAll</a> when they are first created. You can use the bitwise OR operator, "|" to specify multiple platforms.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the file exists, otherwise false.</summary>
        /// <param name="pchFile">const char *: The name of the file.</param>
        /// <param name="eRemoteStoragePlatform"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStoragePlatform" class="bb_apilink">ERemoteStoragePlatform</a>: The platforms that the file will be syncronized to.</param>
        public static bool SetSyncPlatforms(UTF8StringPtr pchFile, RemoteStoragePlatform eRemoteStoragePlatform) => Instance.SetSyncPlatforms(pchFile, eRemoteStoragePlatform);
        /// <summary><code>UGCFileWriteStreamHandle_t FileWriteStreamOpen( const char *pchFile );</code><br />
        /// Creates a new file output stream allowing you to stream out data to the Steam Cloud file in chunks. If the target file already exists, it is not overwritten until <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamClose" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamClose</a> has been called.<br />
        /// <br />
        /// To write data out to this stream you can use <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamWriteChunk" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamWriteChunk</a>, and then to close or cancel you use <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamClose" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamClose</a> and <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamCancel" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamCancel</a> respectively.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCFileWriteStreamHandle_t" class="bb_apilink">UGCFileWriteStreamHandle_t</a><br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_UGCFileStreamHandleInvalid" class="bb_apilink">k_UGCFileStreamHandleInvalid</a> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> You tried to write to an invalid path or filename. Because Steam Cloud is cross platform the files need to have valid names on all supported OSes and file systems. See Microsoft's documentation on <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365247(v=vs.85).aspx" target="_blank" rel="noreferrer">Naming Files, Paths, and Namespaces</a>.<br />
        /// 	</li><li> The current user's Steam Cloud storage quota has been exceeded. They may have run out of space, or have too many files.</li></ul></summary>
        /// <param name="pchFile">const char *: The name of the file to write to.</param>
        public static UGCFileWriteStreamHandle FileWriteStreamOpen(UTF8StringPtr pchFile) => Instance.FileWriteStreamOpen(pchFile);
        /// <summary><code>bool FileWriteStreamWriteChunk( UGCFileWriteStreamHandle_t writeHandle, const void *pvData, int32 cubData );</code><br />
        /// Writes a blob of data to the file write stream.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the data was successfully written to the file write stream.<br />
        /// <b>false</b> if <code class="bb_code bb_code_inline nohighlight">writeHandle</code> is not a valid file write stream, <code class="bb_code bb_code_inline nohighlight">cubData</code> is negative or larger than <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_unMaxCloudFileChunkSize" class="bb_apilink">k_unMaxCloudFileChunkSize</a>, or the current user's Steam Cloud storage quota has been exceeded. They may have run out of space, or have too many files.</summary>
        /// <param name="writeHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCFileWriteStreamHandle_t" class="bb_apilink">UGCFileWriteStreamHandle_t</a>: The file write stream to write to.</param>
        /// <param name="pvData">const void *: The data to write to the stream.</param>
        /// <param name="cubData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pvData</code> in bytes.</param>
        public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle writeHandle, void* pvData, int cubData) => Instance.FileWriteStreamWriteChunk(writeHandle, pvData, cubData);
        /// <summary><code>bool FileWriteStreamClose( UGCFileWriteStreamHandle_t writeHandle );</code><br />
        /// Closes a file write stream that was started by <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamOpen" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamOpen</a>.<br />
        /// <br />
        /// This flushes the stream to the disk, overwriting the existing file if there was one.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the file write stream was successfully closed, the file has been committed to the disk.<br />
        /// <b>false</b> if <code class="bb_code bb_code_inline nohighlight">writeHandle</code> is not a valid file write stream.</summary>
        /// <param name="writeHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCFileWriteStreamHandle_t" class="bb_apilink">UGCFileWriteStreamHandle_t</a>: The file write stream to close.</param>
        public static bool FileWriteStreamClose(UGCFileWriteStreamHandle writeHandle) => Instance.FileWriteStreamClose(writeHandle);
        /// <summary><code>bool FileWriteStreamCancel( UGCFileWriteStreamHandle_t writeHandle );</code><br />
        /// Cancels a file write stream that was started by <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamOpen" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamOpen</a>.<br />
        /// <br />
        /// This trashes all of the data written and closes the write stream, but if there was an existing file with this name, it remains untouched.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="writeHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCFileWriteStreamHandle_t" class="bb_apilink">UGCFileWriteStreamHandle_t</a>: The file write stream to cancel.</param>
        public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle writeHandle) => Instance.FileWriteStreamCancel(writeHandle);
        /// <summary><code>bool FileExists( const char *pchFile );</code><br />
        /// Checks whether the specified file exists.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the file exists; otherwise, <b>false</b>.</summary>
        /// <param name="pchFile">const char *: The name of the file.</param>
        public static bool FileExists(UTF8StringPtr pchFile) => Instance.FileExists(pchFile);
        /// <summary><code>bool FilePersisted( const char *pchFile );</code><br />
        /// Checks if a specific file is persisted in the steam cloud.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the file exists and the file is persisted in the Steam Cloud.<br />
        /// <b>false</b> if <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileForget" class="bb_apilink">ISteamRemoteStorage::FileForget</a> was called on it and is only available locally.</summary>
        /// <param name="pchFile">const char *: The name of the file.</param>
        public static bool FilePersisted(UTF8StringPtr pchFile) => Instance.FilePersisted(pchFile);
        /// <summary><code>int32 GetFileSize( const char *pchFile );</code><br />
        /// Gets the specified files size in bytes.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a><br />
        /// The size of the file in bytes. Returns<b>0</b> if the file does not exist.</summary>
        /// <param name="pchFile">const char *: The name of the file.</param>
        public static int GetFileSize(UTF8StringPtr pchFile) => Instance.GetFileSize(pchFile);
        /// <summary><code>int64 GetFileTimestamp( const char *pchFile );</code><br />
        /// Gets the specified file's last modified timestamp in Unix epoch format (seconds since Jan 1st 1970).<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int64" class="bb_apilink">int64</a><br />
        /// The last modified timestamp in Unix epoch format (seconds since Jan 1st 1970).</summary>
        /// <param name="pchFile">const char *: The name of the file.</param>
        public static long GetFileTimestamp(UTF8StringPtr pchFile) => Instance.GetFileTimestamp(pchFile);
        /// <summary><code>ERemoteStoragePlatform GetSyncPlatforms( const char *pchFile );</code><br />
        /// Obtains the platforms that the specified file will syncronize to.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStoragePlatform" class="bb_apilink">ERemoteStoragePlatform</a><br />
        /// Bitfield containing the platforms that the file was set to with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SetSyncPlatforms" class="bb_apilink">ISteamRemoteStorage::SetSyncPlatforms</a>.</summary>
        /// <param name="pchFile">const char *: The name of the file.</param>
        public static RemoteStoragePlatform GetSyncPlatforms(UTF8StringPtr pchFile) => Instance.GetSyncPlatforms(pchFile);
        /// <summary><code>int32 GetFileCount();</code>Gets the total number of local files synchronized by Steam Cloud.<br />
        /// <br />
        /// Used for enumeration with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetFileNameAndSize" class="bb_apilink">ISteamRemoteStorage::GetFileNameAndSize</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a><br />
        /// The number of files present for the current user, including files in subfolders.</summary>
        /// 
        public static int GetFileCount() => Instance.GetFileCount();
        /// <summary><code>const char * GetFileNameAndSize( int iFile, int32 *pnFileSizeInBytes );</code><br />
        /// Gets the file name and size of a file from the index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetFileCount" class="bb_apilink">ISteamRemoteStorage::GetFileCount</a> first to get the number of files.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The name of the file at the specified index, if it exists. Returns an empty string ("") if the file doesn't exist.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>int32 fileCount = SteamRemoteStorage()-&gt;GetFileCount();
        /// for ( int i = 0; i &lt; fileCount; ++i ) {
        ///     int32 fileSize;
        ///     const char *fileName = SteamRemoteStorage()-&gt;GetFileNameAndSize( i, &amp;fileSize );
        ///     // Do something with fileSize and fileName
        /// }</code></summary>
        /// <param name="iFile">int: The index of the file, this should be between 0 and <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetFileCount" class="bb_apilink">ISteamRemoteStorage::GetFileCount</a>.</param>
        /// <param name="pnFileSizeInBytes"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> *: Returns the file size in bytes.</param>
        public static UTF8StringPtr GetFileNameAndSize(int iFile, int* pnFileSizeInBytes) => Instance.GetFileNameAndSize(iFile, pnFileSizeInBytes);
        /// <summary><code>bool GetQuota( uint64 *pnTotalBytes, uint64 *puAvailableBytes );</code><br />
        /// Gets the number of bytes available, and used on the users Steam Cloud storage.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b>.</summary>
        /// <param name="pnTotalBytes"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the total amount of bytes the user has access to.</param>
        /// <param name="puAvailableBytes"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the number of bytes available.</param>
        public static bool GetQuota(ulong* pnTotalBytes, ulong* puAvailableBytes) => Instance.GetQuota(pnTotalBytes, puAvailableBytes);
        /// <summary><code>bool IsCloudEnabledForAccount();</code>Checks if the account wide Steam Cloud setting is enabled for this user; or if they disabled it in the Settings-&gt;Cloud dialog.<br />
        /// <br />
        /// Ensure that you are also checking <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#IsCloudEnabledForApp" class="bb_apilink">ISteamRemoteStorage::IsCloudEnabledForApp</a>, as these two options are mutually exclusive.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if Steam Cloud is enabled for this account; otherwise, <b>false</b>.</summary>
        /// 
        public static bool IsCloudEnabledForAccount() => Instance.IsCloudEnabledForAccount();
        /// <summary><code>bool IsCloudEnabledForApp();</code>Checks if the per game Steam Cloud setting is enabled for this user; or if they disabled it in the Game Properties-&gt;Update dialog.<br />
        /// <br />
        /// Ensure that you are also checking <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#IsCloudEnabledForAccount" class="bb_apilink">ISteamRemoteStorage::IsCloudEnabledForAccount</a>, as these two options are mutually exclusive.<br />
        /// <br />
        /// It's generally recommended that you allow the user to toggle this setting within your in-game options, you can toggle it with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SetCloudEnabledForApp" class="bb_apilink">ISteamRemoteStorage::SetCloudEnabledForApp</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if Steam Cloud is enabled for this app; otherwise, <b>false</b>.</summary>
        /// 
        public static bool IsCloudEnabledForApp() => Instance.IsCloudEnabledForApp();
        /// <summary><code>void SetCloudEnabledForApp( bool bEnabled );</code><br />
        /// Toggles whether the Steam Cloud is enabled for your application.<br />
        /// <br />
        /// This setting can be queried with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#IsCloudEnabledForApp" class="bb_apilink">ISteamRemoteStorage::IsCloudEnabledForApp</a>.<br />
        /// <br />
        /// <b>NOTE:</b> This must only ever be called as the direct result of the user explicitly requesting that it's enabled or not. This is typically accomplished with a checkbox within your in-game options.</summary>
        /// <param name="bEnabled">bool: Enable (<b>true</b>) or disable (<b>false</b>) the Steam Cloud for this application?</param>
        public static void SetCloudEnabledForApp(bool bEnabled) => Instance.SetCloudEnabledForApp(bEnabled);
        /// <summary><code>SteamAPICall_t UGCDownload( UGCHandle_t hContent, uint32 unPriority );</code><br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageDownloadUGCResult_t" class="bb_apilink">RemoteStorageDownloadUGCResult_t</a> call result.</summary>
        /// <param name="hContent"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCHandle_t" class="bb_apilink">UGCHandle_t</a>: </param>
        /// <param name="unPriority"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        public static SteamAPICall UGCDownload(UGCHandle hContent, uint unPriority) => Instance.UGCDownload(hContent, unPriority);
        /// <summary><code>bool GetUGCDownloadProgress( UGCHandle_t hContent, int32 *pnBytesDownloaded, int32 *pnBytesExpected );</code><br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="hContent"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCHandle_t" class="bb_apilink">UGCHandle_t</a>: </param>
        /// <param name="pnBytesDownloaded"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> *: </param>
        /// <param name="pnBytesExpected"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> *: </param>
        public static bool GetUGCDownloadProgress(UGCHandle hContent, int* pnBytesDownloaded, int* pnBytesExpected) => Instance.GetUGCDownloadProgress(hContent, pnBytesDownloaded, pnBytesExpected);
        /// <summary><code>bool GetUGCDetails( UGCHandle_t hContent, AppId_t *pnAppID, char **ppchName, int32 *pnFileSizeInBytes, CSteamID *pSteamIDOwner );</code><br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="hContent"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCHandle_t" class="bb_apilink">UGCHandle_t</a>: </param>
        /// <param name="pnAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a> *: </param>
        /// <param name="ppchName">char **: </param>
        /// <param name="pnFileSizeInBytes"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> *: </param>
        /// <param name="pSteamIDOwner"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a> *: </param>
        public static bool GetUGCDetails(UGCHandle hContent, AppId* pnAppID, char** ppchName, int* pnFileSizeInBytes, SteamId* pSteamIDOwner) => Instance.GetUGCDetails(hContent, pnAppID, ppchName, pnFileSizeInBytes, pSteamIDOwner);
        /// <summary><code>int32 UGCRead( UGCHandle_t hContent, void *pvData, int32 cubDataToRead, uint32 cOffset, EUGCReadAction eAction );</code><br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a></summary>
        /// <param name="hContent"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCHandle_t" class="bb_apilink">UGCHandle_t</a>: </param>
        /// <param name="pvData">void *: </param>
        /// <param name="cubDataToRead"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>: </param>
        /// <param name="cOffset"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        /// <param name="eAction"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EUGCReadAction" class="bb_apilink">EUGCReadAction</a>: </param>
        public static int UGCRead(UGCHandle hContent, void* pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction) => Instance.UGCRead(hContent, pvData, cubDataToRead, cOffset, eAction);
        /// <summary><code>int32 GetCachedUGCCount();</code><br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a></summary>
        /// 
        public static int GetCachedUGCCount() => Instance.GetCachedUGCCount();
        /// <summary><code>UGCHandle_t GetCachedUGCHandle( int32 iCachedContent );</code><br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCHandle_t" class="bb_apilink">UGCHandle_t</a></summary>
        /// <param name="iCachedContent"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>: </param>
        public static UGCHandle GetCachedUGCHandle(int iCachedContent) => Instance.GetCachedUGCHandle(iCachedContent);
        /// <summary><code>SteamAPICall_t PublishWorkshopFile( const char *pchFile, const char *pchPreviewFile, AppId_t nConsumerAppId, const char *pchTitle, const char *pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray_t *pTags, EWorkshopFileType eWorkshopFileType );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStoragePublishFileProgress_t" class="bb_apilink">RemoteStoragePublishFileProgress_t</a> call result.</summary>
        /// <param name="pchFile">const char *: </param>
        /// <param name="pchPreviewFile">const char *: </param>
        /// <param name="nConsumerAppId"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: </param>
        /// <param name="pchTitle">const char *: </param>
        /// <param name="pchDescription">const char *: </param>
        /// <param name="eVisibility"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStoragePublishedFileVisibility" class="bb_apilink">ERemoteStoragePublishedFileVisibility</a>: </param>
        /// <param name="pTags"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: </param>
        /// <param name="eWorkshopFileType"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EWorkshopFileType" class="bb_apilink">EWorkshopFileType</a>: </param>
        public static SteamAPICall PublishWorkshopFile(UTF8StringPtr pchFile, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags, WorkshopFileType eWorkshopFileType) => Instance.PublishWorkshopFile(pchFile, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, pTags, eWorkshopFileType);
        /// <summary><code>PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest( PublishedFileId_t unPublishedFileId );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a></summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        public static PublishedFileUpdateHandle CreatePublishedFileUpdateRequest(PublishedFileId unPublishedFileId) => Instance.CreatePublishedFileUpdateRequest(unPublishedFileId);
        /// <summary><code>bool UpdatePublishedFileFile( PublishedFileUpdateHandle_t updateHandle, const char *pchFile );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        /// <param name="pchFile">const char *: </param>
        public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchFile) => Instance.UpdatePublishedFileFile(updateHandle, pchFile);
        /// <summary><code>bool UpdatePublishedFilePreviewFile( PublishedFileUpdateHandle_t updateHandle, const char *pchPreviewFile );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        /// <param name="pchPreviewFile">const char *: </param>
        public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchPreviewFile) => Instance.UpdatePublishedFilePreviewFile(updateHandle, pchPreviewFile);
        /// <summary><code>bool UpdatePublishedFileTitle( PublishedFileUpdateHandle_t updateHandle, const char *pchTitle );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        /// <param name="pchTitle">const char *: </param>
        public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchTitle) => Instance.UpdatePublishedFileTitle(updateHandle, pchTitle);
        /// <summary><code>bool UpdatePublishedFileDescription( PublishedFileUpdateHandle_t updateHandle, const char *pchDescription );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        /// <param name="pchDescription">const char *: </param>
        public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchDescription) => Instance.UpdatePublishedFileDescription(updateHandle, pchDescription);
        /// <summary><code>bool UpdatePublishedFileVisibility( PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        /// <param name="eVisibility"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStoragePublishedFileVisibility" class="bb_apilink">ERemoteStoragePublishedFileVisibility</a>: </param>
        public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle updateHandle, RemoteStoragePublishedFileVisibility eVisibility) => Instance.UpdatePublishedFileVisibility(updateHandle, eVisibility);
        /// <summary><code>bool UpdatePublishedFileTags( PublishedFileUpdateHandle_t updateHandle, SteamParamStringArray_t *pTags );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        /// <param name="pTags"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: </param>
        public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle updateHandle, SteamParamStringArray* pTags) => Instance.UpdatePublishedFileTags(updateHandle, pTags);
        /// <summary><code>SteamAPICall_t CommitPublishedFileUpdate( PublishedFileUpdateHandle_t updateHandle );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageUpdatePublishedFileResult_t" class="bb_apilink">RemoteStorageUpdatePublishedFileResult_t</a> call result.</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        public static SteamAPICall CommitPublishedFileUpdate(PublishedFileUpdateHandle updateHandle) => Instance.CommitPublishedFileUpdate(updateHandle);
        /// <summary><code>SteamAPICall_t GetPublishedFileDetails( PublishedFileId_t unPublishedFileId, uint32 unMaxSecondsOld );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageGetPublishedFileDetailsResult_t" class="bb_apilink">RemoteStorageGetPublishedFileDetailsResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        /// <param name="unMaxSecondsOld"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        public static SteamAPICall GetPublishedFileDetails(PublishedFileId unPublishedFileId, uint unMaxSecondsOld) => Instance.GetPublishedFileDetails(unPublishedFileId, unMaxSecondsOld);
        /// <summary><code>SteamAPICall_t DeletePublishedFile( PublishedFileId_t unPublishedFileId );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageDeletePublishedFileResult_t" class="bb_apilink">RemoteStorageDeletePublishedFileResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        public static SteamAPICall DeletePublishedFile(PublishedFileId unPublishedFileId) => Instance.DeletePublishedFile(unPublishedFileId);
        /// <summary><code>SteamAPICall_t EnumerateUserPublishedFiles( uint32 unStartIndex );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageEnumerateUserPublishedFilesResult_t" class="bb_apilink">RemoteStorageEnumerateUserPublishedFilesResult_t</a> call result.</summary>
        /// <param name="unStartIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        public static SteamAPICall EnumerateUserPublishedFiles(uint unStartIndex) => Instance.EnumerateUserPublishedFiles(unStartIndex);
        /// <summary><code>SteamAPICall_t SubscribePublishedFile( PublishedFileId_t unPublishedFileId );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageSubscribePublishedFileResult_t" class="bb_apilink">RemoteStorageSubscribePublishedFileResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        public static SteamAPICall SubscribePublishedFile(PublishedFileId unPublishedFileId) => Instance.SubscribePublishedFile(unPublishedFileId);
        /// <summary><code>SteamAPICall_t EnumerateUserSubscribedFiles( uint32 unStartIndex );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageEnumerateUserSubscribedFilesResult_t" class="bb_apilink">RemoteStorageEnumerateUserSubscribedFilesResult_t</a> call result.</summary>
        /// <param name="unStartIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        public static SteamAPICall EnumerateUserSubscribedFiles(uint unStartIndex) => Instance.EnumerateUserSubscribedFiles(unStartIndex);
        /// <summary><code>SteamAPICall_t UnsubscribePublishedFile( PublishedFileId_t unPublishedFileId );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageUnsubscribePublishedFileResult_t" class="bb_apilink">RemoteStorageUnsubscribePublishedFileResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        public static SteamAPICall UnsubscribePublishedFile(PublishedFileId unPublishedFileId) => Instance.UnsubscribePublishedFile(unPublishedFileId);
        /// <summary><code>bool UpdatePublishedFileSetChangeDescription( PublishedFileUpdateHandle_t updateHandle, const char *pchChangeDescription );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileUpdateHandle_t" class="bb_apilink">PublishedFileUpdateHandle_t</a>: </param>
        /// <param name="pchChangeDescription">const char *: </param>
        public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchChangeDescription) => Instance.UpdatePublishedFileSetChangeDescription(updateHandle, pchChangeDescription);
        /// <summary><code>SteamAPICall_t GetPublishedItemVoteDetails( PublishedFileId_t unPublishedFileId );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageGetPublishedItemVoteDetailsResult_t" class="bb_apilink">RemoteStorageGetPublishedItemVoteDetailsResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        public static SteamAPICall GetPublishedItemVoteDetails(PublishedFileId unPublishedFileId) => Instance.GetPublishedItemVoteDetails(unPublishedFileId);
        /// <summary><code>SteamAPICall_t UpdateUserPublishedItemVote( PublishedFileId_t unPublishedFileId, bool bVoteUp );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageUpdateUserPublishedItemVoteResult_t" class="bb_apilink">RemoteStorageUpdateUserPublishedItemVoteResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        /// <param name="bVoteUp">bool: </param>
        public static SteamAPICall UpdateUserPublishedItemVote(PublishedFileId unPublishedFileId, bool bVoteUp) => Instance.UpdateUserPublishedItemVote(unPublishedFileId, bVoteUp);
        /// <summary><code>SteamAPICall_t GetUserPublishedItemVoteDetails( PublishedFileId_t unPublishedFileId );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageGetPublishedItemVoteDetailsResult_t" class="bb_apilink">RemoteStorageGetPublishedItemVoteDetailsResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        public static SteamAPICall GetUserPublishedItemVoteDetails(PublishedFileId unPublishedFileId) => Instance.GetUserPublishedItemVoteDetails(unPublishedFileId);
        /// <summary><code>SteamAPICall_t EnumerateUserSharedWorkshopFiles( CSteamID steamId, uint32 unStartIndex, SteamParamStringArray_t *pRequiredTags, SteamParamStringArray_t *pExcludedTags );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageEnumerateUserPublishedFilesResult_t" class="bb_apilink">RemoteStorageEnumerateUserPublishedFilesResult_t</a> call result.</summary>
        /// <param name="steamId"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: </param>
        /// <param name="unStartIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        /// <param name="pRequiredTags"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: </param>
        /// <param name="pExcludedTags"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: </param>
        public static SteamAPICall EnumerateUserSharedWorkshopFiles(SteamId steamId, uint unStartIndex, SteamParamStringArray* pRequiredTags, SteamParamStringArray* pExcludedTags) => Instance.EnumerateUserSharedWorkshopFiles(steamId, unStartIndex, pRequiredTags, pExcludedTags);
        /// <summary><code>SteamAPICall_t PublishVideo( EWorkshopVideoProvider eVideoProvider, const char *pchVideoAccount, const char *pchVideoIdentifier, const char *pchPreviewFile, AppId_t nConsumerAppId, const char *pchTitle, const char *pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray_t *pTags );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStoragePublishFileProgress_t" class="bb_apilink">RemoteStoragePublishFileProgress_t</a> call result.</summary>
        /// <param name="eVideoProvider"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EWorkshopVideoProvider" class="bb_apilink">EWorkshopVideoProvider</a>: </param>
        /// <param name="pchVideoAccount">const char *: </param>
        /// <param name="pchVideoIdentifier">const char *: </param>
        /// <param name="pchPreviewFile">const char *: </param>
        /// <param name="nConsumerAppId"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: </param>
        /// <param name="pchTitle">const char *: </param>
        /// <param name="pchDescription">const char *: </param>
        /// <param name="eVisibility"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStoragePublishedFileVisibility" class="bb_apilink">ERemoteStoragePublishedFileVisibility</a>: </param>
        /// <param name="pTags"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: </param>
        public static SteamAPICall PublishVideo(WorkshopVideoProvider eVideoProvider, UTF8StringPtr pchVideoAccount, UTF8StringPtr pchVideoIdentifier, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags) => Instance.PublishVideo(eVideoProvider, pchVideoAccount, pchVideoIdentifier, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, pTags);
        /// <summary><code>SteamAPICall_t SetUserPublishedFileAction( PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageSetUserPublishedFileActionResult_t" class="bb_apilink">RemoteStorageSetUserPublishedFileActionResult_t</a> call result.</summary>
        /// <param name="unPublishedFileId"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: </param>
        /// <param name="eAction"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EWorkshopFileAction" class="bb_apilink">EWorkshopFileAction</a>: </param>
        public static SteamAPICall SetUserPublishedFileAction(PublishedFileId unPublishedFileId, WorkshopFileAction eAction) => Instance.SetUserPublishedFileAction(unPublishedFileId, eAction);
        /// <summary><code>SteamAPICall_t EnumeratePublishedFilesByUserAction( EWorkshopFileAction eAction, uint32 unStartIndex );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageEnumeratePublishedFilesByUserActionResult_t" class="bb_apilink">RemoteStorageEnumeratePublishedFilesByUserActionResult_t</a> call result.</summary>
        /// <param name="eAction"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EWorkshopFileAction" class="bb_apilink">EWorkshopFileAction</a>: </param>
        /// <param name="unStartIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        public static SteamAPICall EnumeratePublishedFilesByUserAction(WorkshopFileAction eAction, uint unStartIndex) => Instance.EnumeratePublishedFilesByUserAction(eAction, unStartIndex);
        /// <summary><code>SteamAPICall_t EnumeratePublishedWorkshopFiles( EWorkshopEnumerationType eEnumerationType, uint32 unStartIndex, uint32 unCount, uint32 unDays, SteamParamStringArray_t *pTags, SteamParamStringArray_t *pUserTags );</code><br />
        /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageEnumerateWorkshopFilesResult_t" class="bb_apilink">RemoteStorageEnumerateWorkshopFilesResult_t</a> call result.</summary>
        /// <param name="eEnumerationType"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EWorkshopEnumerationType" class="bb_apilink">EWorkshopEnumerationType</a>: </param>
        /// <param name="unStartIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        /// <param name="unCount"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        /// <param name="unDays"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        /// <param name="pTags"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: </param>
        /// <param name="pUserTags"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: </param>
        public static SteamAPICall EnumeratePublishedWorkshopFiles(WorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, SteamParamStringArray* pTags, SteamParamStringArray* pUserTags) => Instance.EnumeratePublishedWorkshopFiles(eEnumerationType, unStartIndex, unCount, unDays, pTags, pUserTags);
        /// <summary><code>SteamAPICall_t UGCDownloadToLocation( UGCHandle_t hContent, const char *pchLocation, uint32 unPriority );</code><br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageDownloadUGCResult_t" class="bb_apilink">RemoteStorageDownloadUGCResult_t</a> call result.</summary>
        /// <param name="hContent"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCHandle_t" class="bb_apilink">UGCHandle_t</a>: </param>
        /// <param name="pchLocation">const char *: </param>
        /// <param name="unPriority"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        public static SteamAPICall UGCDownloadToLocation(UGCHandle hContent, UTF8StringPtr pchLocation, uint unPriority) => Instance.UGCDownloadToLocation(hContent, pchLocation, unPriority);
        /// <summary><code>int32 GetLocalFileChangeCount( );</code><br />
        /// Note: only applies to applications flagged as supporting dynamic Steam Cloud sync.<br />
        /// <br />
        /// When your application receives a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageLocalFileChange_t" class="bb_apilink">ISteamRemoteStorage::RemoteStorageLocalFileChange_t</a>, use this method to get the number of changes (file updates and file deletes) that have been made. You can then iterate the changes using <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChange" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChange</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a><br />
        /// The number of local file changes that have occurred.</summary>
        /// 
        public static int GetLocalFileChangeCount() => Instance.GetLocalFileChangeCount();
        /// <summary><code>const char *GetLocalFileChange( int iFile, ERemoteStorageLocalFileChange *pEChangeType, ERemoteStorageFilePathType *pEFilePathType );</code><br />
        /// Note: only applies to applications flagged as supporting dynamic Steam Cloud sync.<br />
        /// <br />
        /// After calling <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChangeCount" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChangeCount</a>, use this method to iterate over the changes. The changes described have already been made to local files. Your application should take appropriate action to reload state from disk, and possibly notify the user. <br />
        /// <br />
        /// For example: The local system had been suspended, during which time the user played elsewhere and uploaded changes to the Steam Cloud. On resume, Steam downloads those changes to the local system before resuming the application. The application receives an <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageLocalFileChange_t" class="bb_apilink">ISteamRemoteStorage::RemoteStorageLocalFileChange_t</a>, and uses <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChangeCount" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChangeCount</a> and <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChange" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChange</a> to iterate those changes. Depending on the application structure and the nature of the changes, the application could:<br />
        /// <br />
        /// <ul class="bb_ul "><li> Re-load game progress to resume at exactly the point where the user was when they exited the game on the other device<br />
        /// </li><li> Notify the user of any synchronized changes that don't require reloading<br />
        /// </li><li> etc</li></ul><br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The file name or full path of the file affected by this change. See comments on <code class="bb_code bb_code_inline nohighlight">pEFilePathType</code> above for more detail.</summary>
        /// <param name="iFile"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>: Zero-based index of the change</param>
        /// <param name="pEChangeType"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStorageLocalFileChange" class="bb_apilink">ERemoteStorageLocalFileChange</a>: What happened to this file</param>
        /// <param name="pEFilePathType"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStorageFilePathType" class="bb_apilink">ERemoteStorageFilePathType</a>: Type of path to the file returned</param>
        public static UTF8StringPtr GetLocalFileChange(int iFile, RemoteStorageLocalFileChangeType* pEChangeType, RemoteStorageFilePathType* pEFilePathType) => Instance.GetLocalFileChange(iFile, pEChangeType, pEFilePathType);
        /// <summary><code>bool BeginFileWriteBatch( );</code><br />
        /// Use this along with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EndFileWriteBatch" class="bb_apilink">EndFileWriteBatch</a> to wrap a set of local file writes/deletes that should be considered part of one single state change. For example, if saving game progress requires updating both <code class="bb_code bb_code_inline nohighlight">savegame1.dat</code> and <code class="bb_code bb_code_inline nohighlight">maxprogress.dat</code>, wrap those operations with calls to <code class="bb_code bb_code_inline nohighlight">BeginFileWriteBatch</code> and <code class="bb_code bb_code_inline nohighlight">EndFileWriteBatch</code>.<br />
        /// <br />
        /// These functions provide a hint to Steam which will help it manage the app's Cloud files. Using these functions is optional, however it will provide better reliability.<br />
        /// <br />
        /// Note that the functions may be used whether the writes are done using the <code class="bb_code bb_code_inline nohighlight">ISteamRemoteStorage</code> API, or done directly to local disk (where AutoCloud is used). <br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the write batch was begun, <b>false</b> if there was a batch already in progress.</summary>
        /// 
        public static bool BeginFileWriteBatch() => Instance.BeginFileWriteBatch();
        /// <summary><code>bool EndFileWriteBatch( );</code><br />
        /// Use this along with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#BeginFileWriteBatch" class="bb_apilink">BeginFileWriteBatch</a> - see that documentation for more details.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the write batch was ended, <b>false</b> if there was no batch already in progress.</summary>
        /// 
        public static bool EndFileWriteBatch() => Instance.EndFileWriteBatch();
    }
}