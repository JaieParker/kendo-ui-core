<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/aspx/Views/Shared/Web.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<div class="box hidden-on-narrow" style="margin-bottom: 30px;">                
    <h4>Console log</h4>
    <div class="console"></div>
</div>

<%= Html.Kendo().Window()
        .Name("window")
        .Width(630)
        .Height(315)
        .Title("Rams's Ten Principles of Good Design")
        .Actions(actions => actions.Refresh().Close())
        .LoadContentFrom("ajaxcontent1", "window")
        .Draggable()
        .Events(events => events
            .Open("onOpen")
            .Activate("onActivate")
            .Close("onClose")
            .Refresh("onRefresh")
            .Resize("onResize")
            .DragStart("onDragStart")
            .DragEnd("onDragEnd")
            .Deactivate("onDeactivate")
        )
%>

<span id="undo" class="k-button hidden-on-narrow">Click here to open the window.</span>

<div class="responsive-message"></div>

<script>
    function onOpen(e) {
        kendoConsole.log("event :: open");
    }

    function onClose(e) {
        kendoConsole.log("event :: close");
    }

    function onActivate(e) {
        kendoConsole.log("event :: activate");
    }

    function onDeactivate(e) {
        kendoConsole.log("event :: deactivate");
    }

    function onRefresh(e) {
        kendoConsole.log("event :: refresh");
    }

    function onResize(e) {
        kendoConsole.log("event :: resize");
    }

    function onDragStart(e) {
        kendoConsole.log("event :: dragstart");
    }

    function onDragEnd(e) {
        kendoConsole.log("event :: dragend");
    }

    $(document).ready(function() {
        $("#undo").bind("click", function() {
            $("#window").data("kendoWindow").open();
        })
    });
</script>

<style>

    #example
    {
        min-height:600px;
    }

    #undo {
        text-align: center;
        position: absolute;
        white-space: nowrap;
        padding: 1em;
        cursor: pointer;
    }

    @media screen and (max-width: 1023px) {
        div.k-window {
            display: none !important;
        }
    }
</style>
</asp:Content>