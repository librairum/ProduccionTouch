var ref = function(){
				
                $('#grid').trigger('footable_initialized');
				$('#grid').trigger('footable_resize');
				$('#grid').trigger('footable_redraw');
            	
}

$.fn.ClearData = function(){
	$(this).find('tbody').remove();
	$(this).find('thead').remove();
	$(this).find('tfoot').remove();

}


$.fn.config = function(col){

	var cant = 0;
	var _col = "";

	if(col.length > 1){
		cant = 2;
		 _col =  '<tr> <th data-toggle="true" >' + col[0] +'</th><th data-hide="phone">' + col[1];
		 _col +='</th>';

	}
	else{
		_col =  '<th data-toggle="true">' + col[0] +'</th>';
		cant = 1;
	}

	alert(col.length);
	
	for (var i = cant; i < col.length ; i++) {
		_col += '<th data-hide="tablet,phone">' + col[i];
		_col +='</th>';
	};
	_col += '<th data-sort-ignore="true" data-hide="tablet,phone" data-name="Delete"></th>';
	_col += '</tr>';

	$(this).find('thead').append(_col);

	ref();
}



$.fn.lista = function (_data) {
				var row = '<tr>';
				$.each(_data, function(key, val){
				    row += '<td>' + val + '</td>';
			     });
				row += '</tr>';
				(this).find('tbody').append(row);
			    ref();
}