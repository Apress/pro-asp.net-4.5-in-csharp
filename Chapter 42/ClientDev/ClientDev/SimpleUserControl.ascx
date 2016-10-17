<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="SimpleUserControl.ascx.cs" Inherits="ClientDev.SimpleUserControl" %>

<script>
    if (jQuery) {
        $(document).ready(function () {
            $('#nameSpan').text("Simple User Control");
        });
    } else {
        throw new Error("jQuery is required");
    }
</script>

<div>
    This is the <span id="nameSpan"></span>
</div>
