Public Class SiteHelpers

    ' ' GetSiteInfo      
    '********************
    '
    ' Get Site Info - This is where site info is changed as needed.
    '
    <AllowAnonymous>
    Public Shared Function GetSiteInfo(AttributeName As String) As String

        Dim siteURL As String = LCase(RootUrl())

        ' Site Name
        If AttributeName = "SiteName" Then
            Return "Avon Park Nazarene Church"
        End If
        If AttributeName = "SiteNameShort" Then
            Return "Nazarene Life"
        End If

        ' Site Description
        If AttributeName = "SiteDescription" Then
            Return "This web site is dedicated to the Nazarene Life!"
        End If

        ' Site URL
        If AttributeName = "SiteURL" Then
            Return "http://APNazarene.illustrate.net"
        End If

        ' Site Contact
        If AttributeName = "SiteContact" Then
            Return "Patricia Bridewell"
        End If

        ' Site Address
        If AttributeName = "Address1" Then
            Return "707 W Main Street - Box 1118"
        End If
        If AttributeName = "Address2" Then
            Return "Avon Park, Forida 33826"
        End If

        ' Phone
        If AttributeName = "Phone1" Then
            Return "863-453-4851"
        End If

        ' Site Email
        If AttributeName = "SiteEmailContact" Then
            Return "apnazarene@apnazarene.org"
        End If

        ' Site Sales and Support
        If AttributeName = "SiteEmailSales" Then
            Return "Sales@example.com"
        End If
        If AttributeName = "SiteEmailSupport" Then
            Return "Info@example.com"
        End If

        ' Facebook Page
        If AttributeName = "SiteFacebookPageURL" Then
            Return "https://www.facebook.com/APNazarene/"
        End If

        ' Google Maps Location
        If AttributeName = "SiteGoogleMapURL" Then
            Return "https://www.google.com/maps/place/Avon+Park+Church+of+the+Nazarene/@27.5953222,-81.5091936,15z/data=!4m5!3m4!1s0x0:0x3b2af50abe7f8f95!8m2!3d27.5953222!4d-81.5091936"
        End If

        ' Site Images
        If AttributeName = "BigLogo" Then
            Return "/Content/Catagories/Svg/Logo1.svg"
        End If
        If AttributeName = "SmallLogo" Then
            Return "/Content/Catagories/Svg/Bird_white.svg"
        End If
        If AttributeName = "PageImage_About" Then
            Return "https:/illustrate.net/APNazarene/Content/Catagories/PageImages/900x800-image-01.jpg"
        End If
        If AttributeName = "LinkShare" Then
            Return "https:/illustrate.net/APNazarene/Content/Catagories/LinkShares/1200x630-Linkshare-01.jpg"
        End If

        ' Site Designer
        If AttributeName = "SiteDesigner" Then
            Return "The Mikish Group"
        End If
        If AttributeName = "SiteEmailDesigner" Then
            Return "Mikish.Vaughn@Gmail.com"
        End If
        If AttributeName = "SiteDesignerURL" Then
            Return "https://mikish.com"
        End If
        If AttributeName = "SiteDesignerLogo" Then
            Return "/Content/Catagories/Svg/BlueSun.svg"
        End If

        'If we make it here then there was a coding failure!
        Return "Oops!" ' :-(

    End Function

    ' ' RootURL()        
    '********************
    '
    ' Used to return the Root URL to determine the site address and therefore identity.
    '
    <AllowAnonymous>
    Public Shared Function RootUrl() As String
        Return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/")
    End Function

    ' ' ImageCount() 
    '********************
    '
    ' Returns the image count in an image folder.
    '
    <AllowAnonymous>
    Public Shared Function ImageCount(folder As String, extension As String) As Integer

        Dim Count As Integer = 1
        Try
            If HttpContext.Current.Request.IsLocal Then
                Count = IO.Directory.GetFiles("D:\Projects\Repos\APNazarene\Content\Catagories\" + folder + "\", "*" + extension).Length()
            Else
                Count = IO.Directory.GetFiles("h:\root\home\mikish-001\www\illustrate\APNazarene\Content\Catagories\" + folder + "\", "*" + extension).Length()
            End If
        Catch ex As Exception
            MsgBox("Image Directory Not Found", MsgBoxStyle.Critical)
            Return Count
        End Try

        Return Count

    End Function

    ' GetImageLocation 
    '********************
    '
    <AllowAnonymous>
    Public Shared Function GetImageLocation() As String

        Dim ImageLocation As String = "https://Illustrate.net/APNazarene/Content/Catagories/"
        If HttpContext.Current.Request.IsLocal Then
            ImageLocation = "/Content/Catagories/"
        End If

        Return ImageLocation

    End Function

    ' Overrides   
    '********************
    '
    ' Additional Class Functions
    '
    Public Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function
    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class