$(document).ready(function () {
    // Add click event listener to the update button
    $('#updateLineBtn').click(function () {
        if ($('#orderItemsTable .selected').length > 0) {
            // If a row is selected, perform the update action here
            var material = $('#materialDropdown').val();
            var shortText = $('#shortText').val();
            var unit = $('#unit').val();
            var quantity = $('#ItemQuantity').val();
            var rate = $('#ItemRate').val();
            var amount = $('#ItemValue').val();
            var expectedDate = $('#expecteddate').val();

            // Serialize the current table data
            var tabledata = $('#orderItemsTable').serialize();

            // Perform the update action
            updateRow(material, shortText, unit, quantity, rate, amount, expectedDate, tabledata);
        } else {
            // If no row is selected, show an error message or perform alternative action
            alert("Please select any row to update");
        }
    });

    // Function to perform the update action
    function updateRow(material, shortText, unit, quantity, rate, amount, expectedDate, tabledata) {
        // Serialize the current table data
        var changeddata = $('#orderItemsTable').serialize();
        // Check if the previous and new data are the same
        if (tabledata !== changeddata) {
            var newRow = $('<tr>');
            newRow.append('<td><button class="btn btn-secondary dropdown-toggle" type="button" data-toggle="dropdown">Select</button></td>');
            newRow.append('<td>' + material + '</td>');
            newRow.append('<td>' + shortText + ' ' + unit + ' ' + quantity + '</td>');
            newRow.append('<td>' + rate + '</td>');
            newRow.append('<td>' + amount + '</td>');
            newRow.append('<td>' + expectedDate + '</td>');

            // Append the new row to the table body
            $('#orderItemsTable tbody').append(newRow);
        } else {
            alert("No changes made to the data.");
        }
    }

    // Add click event listener to the table rows to toggle selection
    $('#orderItemsTable tbody').on('click', 'tr', function () {
        $(this).toggleClass('selected').siblings().removeClass('selected');
    });
});
