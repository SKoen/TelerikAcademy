/**
 * Created by Sh0rti on 6/16/2014.
 */
(function ($){
    $.fn.dropdown = function() {
        var $this = $(this),
            childrens = $this.children(),
            element = $('<div>').addClass('dropdown-list-container'),
            list = $('<ul>').addClass('dropdown-list-options').css({
                'display': 'none',
                'position': 'absolute',
                'padding': 0,
                'margin': 0
            });
        $this.css('display', 'none');
        var dateValueIndex = $(this).val();
        for(var i= 0,len = childrens.length; i < len; i++){
            list.append($('<li>').addClass('dropdown-list-option')
                            .attr('data-value', i)
                            .text(childrens[i].text)
                            .css({
                                'list-style-type': 'none',
                                'background': 'red',
                                'border': '1px solid',
                                'font-size': '26px',
                                'width': '132px',
                                'text-align': 'center'
                            })
                            .on('click',  function () {
                                 $this.find("option:selected").removeAttr("selected");
                                 $this.find('option[value="' + dateValueIndex + '"]').attr("selected","true");
                                 currentSelection.text($(this).text());
                                 list.css('display', 'none');
                            }));
        }

        var currentSelection = $('<div/>').text(list.children()
                                    .first().text()).attr('id', 'current')
                                    .css({
                                        'background': 'red',
                                        'border': '1px solid',
                                        'font-size': '26px',
                                        'width': '132px',
                                        'text-align': 'center'
                                    });
        currentSelection.on('click', function () {
            if (list.css('display') == 'block') {
                list.css('display', 'none');
            } else {
                list.css('display', 'block');
            }
        })

        $this.after(element.append(list).prepend(currentSelection));

         return $this;
    }
}(jQuery));