@code
    ' Get Image Info
    Dim BigLogo As String = SiteHelpers.GetSiteInfo("BigLogo")
End Code

<div class="col-lg-5">

    <!-- Big Logo and Site Name -->
    <div class="card h-100 bg-transparent noborder" style="background-color: transparent;">
        <div class="card-body text-center p-0">
            
            <!-- Show  Big Logo -->
            <img src=@BigLogo class="img-fluid biglogo" alt="Responsive Big Logo" />

            <!-- Site Name -->
            @*<h2 class="text-break font-weight-light" style="color:darkgreen; text-shadow: 1px 1px 1px gray, 0 0 1px gray;">Avon Park</h2> 
            <h2 class="text-break font-weight-light" style="color: darkgreen; text-shadow: 1px 1px 1px gray, 0 0 1px gray;">Nazarene Church</h2>*@                
            
        </div>
    </div>

    <!-- Site Description -->
    <div class="card text-white bg-dark my-2 py-2">
        <div class="card-body lh-sm shadow">
            <p class="text-white m-0 py-1">WHO ARE WE?</p>
            <p class="text-white m-0 py-2">Our congregation is a family, part of the global family of people called Nazarenes, who, in turn, are part of the Body of Christ Universal. We invite you to worship and learn with us.
            </p>
        </div>
    </div>

</div>
