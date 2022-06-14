using System;

namespace Win32.Constants
{
    [Flags]
    public enum SHGetFileInfo : uint
    {
        /// <summary>
        /// <para>256</para>
        /// Retrieve the handle to the icon that represents the file and the index of the icon within the system image list. The handle is copied to the hIcon member of the structure specified by psfi, and the index is copied to the iIcon member.
        /// </summary>
        SHGFI_ICON = 0x00000100,

        /// <summary>
        /// <para>512</para>
        /// Retrieve the display name for the file, which is the name as it appears in Windows Explorer. The name is copied to the szDisplayName member of the structure specified in psfi. The returned display name uses the long file name, if there is one, rather than the 8.3 form of the file name. Note that the display name can be affected by settings such as whether extensions are shown.
        /// </summary>
        SHGFI_DISPLAYNAME = 0x00000200,

        /// <summary>
        /// <para>1024</para>
        /// Retrieve the string that describes the file's type. The string is copied to the szTypeName member of the structure specified in psfi.
        /// </summary>
        SHGFI_TYPENAME = 0x00000400,

        /// <summary>
        /// <para>2048</para>
        /// Retrieve the item attributes. The attributes are copied to the dwAttributes member of the structure specified in the psfi parameter. These are the same attributes that are obtained from <see href="https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-getattributesof">IShellFolder::GetAttributesOf</see>.
        /// </summary>
        SHGFI_ATTRIBUTES = 0x00000800,

        /// <summary>
        /// <para>4096</para>
        /// Retrieve the name of the file that contains the icon representing the file specified by pszPath, as returned by the <see href="https://docs.microsoft.com/en-us/windows/win32/api/shlobj_core/nf-shlobj_core-iextracticona-geticonlocation">IExtractIcon::GetIconLocation</see> method of the file's icon handler. Also retrieve the icon index within that file. The name of the file containing the icon is copied to the szDisplayName member of the structure specified by psfi. The icon's index is copied to that structure's iIcon member.
        /// </summary>
        SHGFI_ICONLOCATION = 0x00001000,

        /// <summary>
        /// <para>8192</para>
        /// Retrieve the type of the executable file if pszPath identifies an executable file. The information is packed into the return value. This flag cannot be specified with any other flags.
        /// </summary>
        SHGFI_EXETYPE = 0x00002000,

        /// <summary>
        /// <para>16384</para>
        /// Retrieve the index of a system image list icon. If successful, the index is copied to the iIcon member of psfi. The return value is a handle to the system image list. Only those images whose indices are successfully copied to iIcon are valid. Attempting to access other images in the system image list will result in undefined behavior.
        /// </summary>
        SHGFI_SYSICONINDEX = 0x00004000,

        /// <summary>
        /// <para>32768</para>
        /// Modify SHGFI_ICON, causing the function to add the link overlay to the file's icon. The SHGFI_ICON flag must also be set.
        /// </summary>
        SHGFI_LINKOVERLAY = 0x00008000,

        /// <summary>
        /// <para>65536</para>
        /// Modify SHGFI_ICON, causing the function to blend the file's icon with the system highlight color. The SHGFI_ICON flag must also be set.
        /// </summary>
        SHGFI_SELECTED = 0x00010000,

        /// <summary>
        /// <para>131072</para>
        /// Modify SHGFI_ATTRIBUTES to indicate that the dwAttributes member of the SHFILEINFO structure at psfi contains the specific attributes that are desired. These attributes are passed to <see href="https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-getattributesof">IShellFolder::GetAttributesOf</see>. If this flag is not specified, 0xFFFFFFFF is passed to IShellFolder::GetAttributesOf, requesting all attributes. This flag cannot be specified with the SHGFI_ICON flag.
        /// </summary>
        SHGFI_ATTR_SPECIFIED = 0x00020000,

        /// <summary>
        /// <para>0</para>
        /// Modify SHGFI_ICON, causing the function to retrieve the file's large icon. The SHGFI_ICON flag must also be set.
        /// </summary>
        SHGFI_LARGEICON = 0x000000000,

        /// <summary>
        /// <para>1</para>
        /// Modify SHGFI_ICON, causing the function to retrieve the file's small icon. Also used to modify SHGFI_SYSICONINDEX, causing the function to return the handle to the system image list that contains small icon images. The SHGFI_ICON and/or SHGFI_SYSICONINDEX flag must also be set.
        /// </summary>
        SHGFI_SMALLICON = 0x000000001,

        /// <summary>
        /// <para>2</para>
        /// Modify SHGFI_ICON, causing the function to retrieve the file's open icon. Also used to modify SHGFI_SYSICONINDEX, causing the function to return the handle to the system image list that contains the file's small open icon. A container object displays an open icon to indicate that the container is open. The SHGFI_ICON and/or SHGFI_SYSICONINDEX flag must also be set.
        /// </summary>
        SHGFI_OPENICON = 0x000000002,

        /// <summary>
        /// <para>4</para>
        /// Modify SHGFI_ICON, causing the function to retrieve a Shell-sized icon. If this flag is not specified the function sizes the icon according to the system metric values. The SHGFI_ICON flag must also be set.
        /// </summary>
        SHGFI_SHELLICONSIZE = 0x000000004,

        /// <summary>
        /// <para>16</para>
        /// Indicates that the function should not attempt to access the file specified by pszPath. Rather, it should act as if the file specified by pszPath exists with the file attributes passed in dwFileAttributes. This flag cannot be combined with the SHGFI_ATTRIBUTES, SHGFI_EXETYPE, or SHGFI_PIDL flags.
        /// </summary>
        SHGFI_USEFILEATTRIBUTES = 0x00000010,

        /// <summary>
        /// <para>32</para>
        /// <see href="https://docs.microsoft.com/en-us/previous-versions/windows/desktop/legacy/bb776779(v=vs.85)">Version 5.0</see>. Apply the appropriate overlays to the file's icon. The SHGFI_ICON flag must also be set.
        /// </summary>
        SHGFI_ADDOVERLAYS = 0x00000020,

        /// <summary>
        /// <para>64</para>
        /// <see href="https://docs.microsoft.com/en-us/previous-versions/windows/desktop/legacy/bb776779(v=vs.85)">Version 5.0</see>. Return the index of the overlay icon. The value of the overlay index is returned in the upper eight bits of the iIcon member of the structure specified by psfi. This flag requires that the SHGFI_ICON be set as well.
        /// </summary>
        SHGFI_OVERLAYINDEX = 0x00000040,

        /// <summary>
        /// <para>8</para>
        /// Indicate that pszPath is the address of an <see href="https://docs.microsoft.com/en-us/windows/win32/api/shtypes/ns-shtypes-itemidlist">ITEMIDLIST</see> structure rather than a path name.
        /// </summary>
        SHGFI_PIDL = 0x000000008
    }
}
