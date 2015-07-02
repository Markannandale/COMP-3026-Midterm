@ModelType IEnumerable(Of MarkAnnandaleMidtermWeb.Course)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CourseCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CourseName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Course_Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CourseCosts)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CourseCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CourseName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Course_Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CourseCosts)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
