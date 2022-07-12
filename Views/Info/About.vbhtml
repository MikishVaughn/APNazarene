@Code
    ' Get Title and Site Name
    ViewData("Title") = ViewData("Message")
End Code

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 align-items-end mb-3">

        <!-- Brand and description -->
        @Html.Partial("Cards/About/_Brand")

        <!-- About Video -->
        @Html.Partial("_AboutVideo")

    </div>
    
    <!-- Content Row-->
    <div class="row gx-1 gx-lg-5">

        <!-- Schedule Card -->
        @Html.Partial("Cards/About/_OnlineWorship")

        <!-- Fundraising Card -->
        @Html.Partial("Cards/About/_Calendar")

        <!-- Merchandise Card -->
        @Html.Partial("Cards/About/_Members")

    </div>

    <!-- Important Info Card -->
    <div class="row gx-1 gx-lg-5">
        @Html.Partial("Cards/About/_Links")
    </div>
</div>
