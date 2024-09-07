Namespace CoreServices.WindowsApiInterop.Enums

    ''' <summary>
    ''' Represents the various types of information that can be retrieved about an access token.
    ''' These values are used with the <see cref="NativeMethods.GetTokenInformation"/> function to specify the type of information 
    ''' being requested.
    ''' </summary>
    ''' <remarks>
    ''' The <c>TokenInformationClass</c> enum is used to identify specific information about a security token in Windows.
    ''' This enum is primarily used in conjunction with the <see cref="NativeMethods.GetTokenInformation"/> function to query details about 
    ''' user tokens, privileges, groups, and other security-related attributes.
    ''' 
    ''' The following is the C++ signature for the <c>TOKEN_INFORMATION_CLASS</c> enumeration:
    ''' 
    ''' <code>
    ''' typedef enum _TOKEN_INFORMATION_CLASS {
    '''   TokenUser = 1,
    '''   TokenGroups,
    '''   TokenPrivileges,
    '''   TokenOwner,
    '''   TokenPrimaryGroup,
    '''   TokenDefaultDacl,
    '''   TokenSource,
    '''   TokenType,
    '''   TokenImpersonationLevel,
    '''   TokenStatistics,
    '''   TokenRestrictedSids,
    '''   TokenSessionId,
    '''   TokenGroupsAndPrivileges,
    '''   TokenSessionReference,
    '''   TokenSandBoxInert,
    '''   TokenAuditPolicy,
    '''   TokenOrigin,
    '''   TokenElevationType,
    '''   TokenLinkedToken,
    '''   TokenElevation,
    '''   TokenHasRestrictions,
    '''   TokenAccessInformation,
    '''   TokenVirtualizationAllowed,
    '''   TokenVirtualizationEnabled,
    '''   TokenIntegrityLevel,
    '''   TokenUIAccess,
    '''   TokenMandatoryPolicy,
    '''   TokenLogonSid,
    '''   TokenIsAppContainer,
    '''   TokenCapabilities,
    '''   TokenAppContainerSid,
    '''   TokenAppContainerNumber,
    '''   TokenUserClaimAttributes,
    '''   TokenDeviceClaimAttributes,
    '''   TokenRestrictedUserClaimAttributes,
    '''   TokenRestrictedDeviceClaimAttributes,
    '''   TokenDeviceGroups,
    '''   TokenRestrictedDeviceGroups,
    '''   TokenSecurityAttributes,
    '''   TokenIsRestricted,
    '''   TokenProcessTrustLevel,
    '''   TokenPrivateNameSpace,
    '''   TokenSingletonAttributes,
    '''   TokenBnoIsolation,
    '''   TokenChildProcessFlags,
    '''   TokenIsLessPrivilegedAppContainer,
    '''   TokenIsSandboxed,
    '''   TokenIsAppSilo,
    '''   TokenLoggingInformation,
    '''   MaxTokenInfoClass
    ''' } TOKEN_INFORMATION_CLASS, *PTOKEN_INFORMATION_CLASS;
    ''' </code>
    ''' 
    ''' For more detailed information about each value, see the official Microsoft documentation:
    ''' <see href="https://learn.microsoft.com/en-us/windows/win32/api/winnt/ne-winnt-token_information_class">TOKEN_INFORMATION_CLASS</see>.
    ''' 
    ''' Note: The <see cref="UsedImplicitlyAttribute"/> attribute is applied to some members of this enumeration to indicate that 
    ''' while they may not be directly referenced in the code, they are retained for completeness and potential future use.
    ''' </remarks>
    Public Enum TokenInformationClass

        ''' <summary>
        ''' The buffer receives a <c>TokenUser</c> structure that contains the user account associated with the access token.
        ''' </summary>
        TokenUser = 1

        ''' <summary>
        ''' The buffer receives a <c>TokenElevationType</c> value that indicates the elevation level of the token.
        ''' </summary>
        TokenElevationType = 18

        ''' <summary>
        ''' The buffer receives a <c>TokenGroups</c> structure that contains the group security identifiers (SIDs) associated with the access token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenGroups"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenGroups

        ''' <summary>
        ''' The buffer receives a <c>TokenPrivileges</c> structure that contains the privileges associated with the access token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenPrivileges"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenPrivileges

        ''' <summary>
        ''' The buffer receives a <c>TokenOwner</c> structure that contains the default owner security identifier (SID) for newly created objects.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenOwner"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenOwner

        ''' <summary>
        ''' The buffer receives a <c>TokenPrimaryGroup</c> structure that contains the primary group SID for the access token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenPrimaryGroup"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenPrimaryGroup

        ''' <summary>
        ''' The buffer receives a <c>TokenDefaultDacl</c> structure that contains the default discretionary access control list (DACL) for the access token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenDefaultDacl"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenDefaultDacl

        ''' <summary>
        ''' The buffer receives a <c>TokenSource</c> structure that contains the source of the access token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenSource"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenSource

        ''' <summary>
        ''' The buffer receives a <c>TokenType</c> value that indicates whether the token is a primary or impersonation token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenType"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenType

        ''' <summary>
        ''' The buffer receives a <c>TokenImpersonationLevel</c> value that indicates the impersonation level of the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenImpersonationLevel"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenImpersonationLevel

        ''' <summary>
        ''' The buffer receives a <c>TokenStatistics</c> structure that contains various token statistics.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenStatistics"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenStatistics

        ''' <summary>
        ''' The buffer receives a <c>TokenRestrictedSids</c> structure that contains the list of restricted SIDs in the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenRestrictedSids"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenRestrictedSids

        ''' <summary>
        ''' The buffer receives a <c>TokenSessionId</c> value that contains the session ID associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenSessionId"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenSessionId

        ''' <summary>
        ''' The buffer receives a <c>TokenGroupsAndPrivileges</c> structure that contains information about the token's groups and privileges.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenGroupsAndPrivileges"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenGroupsAndPrivileges

        ''' <summary>
        ''' This value is reserved for internal use by the operating system.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenSessionReference"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenSessionReference

        ''' <summary>
        ''' The buffer receives a <c>TokenSandBoxInert</c> value that indicates whether the token is sandboxed.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenSandBoxInert"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenSandBoxInert

        ''' <summary>
        ''' The buffer receives a <c>TokenAuditPolicy</c> structure that contains the audit policy associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenAuditPolicy"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenAuditPolicy

        ''' <summary>
        ''' The buffer receives a <c>TokenOrigin</c> structure that contains information about the origin of the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenOrigin"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenOrigin

        ''' <summary>
        ''' The buffer receives a <c>TokenLinkedToken</c> structure that contains a handle to another token that is linked to the token being queried.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenLinkedToken"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenLinkedToken

        ''' <summary>
        ''' The buffer receives a <c>TokenElevation</c> structure that indicates whether the token is elevated.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenElevation"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenElevation

        ''' <summary>
        ''' The buffer receives a <c>TokenHasRestrictions</c> value that indicates whether the token has any restrictions.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenHasRestrictions"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenHasRestrictions

        ''' <summary>
        ''' The buffer receives a <c>TokenAccessInformation</c> structure that contains access control information for the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenAccessInformation"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenAccessInformation

        ''' <summary>
        ''' The buffer receives a <c>TokenVirtualizationAllowed</c> value that indicates whether virtualization is allowed for the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenVirtualizationAllowed"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenVirtualizationAllowed

        ''' <summary>
        ''' The buffer receives a <c>TokenVirtualizationEnabled</c> value that indicates whether virtualization is enabled for the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenVirtualizationEnabled"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenVirtualizationEnabled

        ''' <summary>
        ''' The buffer receives a <c>TokenIntegrityLevel</c> structure that contains the integrity level of the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenIntegrityLevel"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenIntegrityLevel

        ''' <summary>
        ''' The buffer receives a <c>TokenUiAccess</c> value that indicates whether the token is allowed to interact with the user interface.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenUiAccess"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenUiAccess

        ''' <summary>
        ''' The buffer receives a <c>TokenMandatoryPolicy</c> structure that specifies the mandatory policy for the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenMandatoryPolicy"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenMandatoryPolicy

        ''' <summary>
        ''' The buffer receives a <c>TokenLogonSid</c> structure that contains the logon SID of the user associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenLogonSid"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenLogonSid

        ''' <summary>
        ''' The buffer receives a <c>TokenIsAppContainer</c> value that indicates whether the token is associated with an AppContainer.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenIsAppContainer"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenIsAppContainer

        ''' <summary>
        ''' The buffer receives a <c>TokenCapabilities</c> structure that contains the capabilities associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenCapabilities"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenCapabilities

        ''' <summary>
        ''' The buffer receives a <c>TokenAppContainerSid</c> structure that contains the AppContainer SID associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenAppContainerSid"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenAppContainerSid

        ''' <summary>
        ''' The buffer receives a <c>TokenAppContainerNumber</c> value that indicates the AppContainer number associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenAppContainerNumber"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenAppContainerNumber

        ''' <summary>
        ''' The buffer receives a <c>TokenUserClaimAttributes</c> structure that specifies the security attributes for the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenUserClaimAttributes"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenUserClaimAttributes

        ''' <summary>
        ''' The buffer receives a <c>TokenDeviceClaimAttributes</c> structure that specifies the security attributes for the device.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenDeviceClaimAttributes"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenDeviceClaimAttributes

        ''' <summary>
        ''' The buffer receives a <c>TokenRestrictedUserClaimAttributes</c> structure that specifies the restricted security attributes for the user.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenRestrictedUserClaimAttributes"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenRestrictedUserClaimAttributes

        ''' <summary>
        ''' The buffer receives a <c>TokenRestrictedDeviceClaimAttributes</c> structure that specifies the restricted security attributes for the device.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenRestrictedDeviceClaimAttributes"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenRestrictedDeviceClaimAttributes

        ''' <summary>
        ''' The buffer receives a <c>TokenDeviceGroups</c> structure that contains the device groups associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenDeviceGroups"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenDeviceGroups

        ''' <summary>
        ''' The buffer receives a <c>TokenRestrictedDeviceGroups</c> structure that contains the restricted device groups associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenRestrictedDeviceGroups"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenRestrictedDeviceGroups

        ''' <summary>
        ''' The buffer receives a <c>TokenSecurityAttributes</c> structure that specifies the security attributes for the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenSecurityAttributes"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenSecurityAttributes

        ''' <summary>
        ''' The buffer receives a <c>TokenIsRestricted</c> value that indicates whether the token has restrictions.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenIsRestricted"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenIsRestricted

        ''' <summary>
        ''' The buffer receives a <c>TokenProcessTrustLevel</c> structure that contains the process trust level associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenProcessTrustLevel"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenProcessTrustLevel

        ''' <summary>
        ''' The buffer receives a <c>TokenPrivateNameSpace</c> structure that specifies the private namespace information associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenPrivateNameSpace"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenPrivateNameSpace

        ''' <summary>
        ''' The buffer receives a <c>TokenSingletonAttributes</c> structure that specifies the singleton attributes associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenSingletonAttributes"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenSingletonAttributes

        ''' <summary>
        ''' The buffer receives a <c>TokenBnoIsolation</c> value that indicates whether the token is isolated in a BNO container.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenBnoIsolation"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenBnoIsolation

        ''' <summary>
        ''' The buffer receives a <c>TokenChildProcessFlags</c> value that contains the child process flags associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenChildProcessFlags"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenChildProcessFlags

        ''' <summary>
        ''' The buffer receives a <c>TokenIsLessPrivilegedAppContainer</c> value that indicates whether the token is a less privileged AppContainer.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenIsLessPrivilegedAppContainer"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenIsLessPrivilegedAppContainer

        ''' <summary>
        ''' The buffer receives a <c>TokenIsSandboxed</c> value that indicates whether the token is sandboxed.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenIsSandboxed"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenIsSandboxed

        ''' <summary>
        ''' The buffer receives a <c>TokenIsAppSilo</c> value that indicates whether the token is associated with an App Silo.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenIsAppSilo"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenIsAppSilo

        ''' <summary>
        ''' The buffer receives a <c>TokenLoggingInformation</c> structure that contains logging information associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="TokenLoggingInformation"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenLoggingInformation

        ''' <summary>
        ''' The maximum value for this enumeration. This value is reserved for system use only.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="MaxTokenInfoClass"/> is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        MaxTokenInfoClass
    End Enum
End Namespace
