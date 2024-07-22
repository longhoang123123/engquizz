$.ajaxSetup({
    headers: {
        'X-CSRF-TOKEN': $('meta[name="csrf-token"]').attr('content')
    }
});

function removeRow(id, url)
{
    if (confirm('xoa khong the khoi phuc. Ban co chac ?')){
        $.ajax({
            type: 'DELETE',
            datatype: 'JSON',
            data: {id},
            url: url,
            success: function (result){
                if (result.error === false){
                    alert(result.message);
                    window.location.reload();
                }else{
                    alert('xoa loi, vui long thu lai !');
                }
            }
        });
    }
}

//upload
$('#upload').change(function(){
    const form = new FormData();
    form.append('file', $(this)[0].files[0]);

    $.ajax({
        processData: false,
        contentType: false,
        type: 'POST',
        dataType: 'JSON',
        data: form,
        url: '/admin/upload/services',
        success: function (result){
            if(result.error===false){
                $('#image_show').html('<a href="' + result.url + '" target="_blank"> <img src="' + result.url + '" width="100px"></a>');

                $('#thumb').val(result.url);
            }else{
                alert('upload file loi');
            }
        }
    });
});