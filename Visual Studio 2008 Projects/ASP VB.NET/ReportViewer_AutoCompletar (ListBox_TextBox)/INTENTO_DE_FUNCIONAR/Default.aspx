<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
        <title></title>
        <link type="text/css" rel="stylesheet" href="jquery-ui-1.11.4.custom/jquery-ui.css"/>
        <script type="text/javascript" src="jquery-1.12.0.min.js"></script>
        <script type="text/javascript" src="jquery-ui-1.11.4.custom/jquery-ui.js"></script>


        <style type="text/css">
            .ui-menu-item {
                font-family:Verdana,Tahoma,Times New Roman,Arial;
                color:#2d77c2;
                font-Size:small; 
                font-weight:Normal;
            }

  .custom-combobox {

    position: relative;

    display: inline-block;

  }

  .custom-combobox-toggle {

    position: absolute;

    top: 0;

    bottom: 0;

    margin-left: -1px;

    padding: 0;

  }

  .custom-combobox-input {

    margin: 0;

    padding: 5px 10px;

  }

  </style>

  <script>

  (function( $ ) {

    $.widget( "custom.combobox", {

      _create: function() {

        this.wrapper = $( "<span>" )

          .addClass( "custom-combobox" )

          .insertAfter( this.element );

 

        this.element.hide();

        this._createAutocomplete();

        this._createShowAllButton();

      },

 

      _createAutocomplete: function() {

        var selected = this.element.children( ":selected" ),

          value = selected.val() ? selected.text() : "";

 

        this.input = $( "<input>" )

          .appendTo( this.wrapper )

          .val( value )

          .attr( "title", "" )

          .addClass( "custom-combobox-input ui-widget ui-widget-content ui-state-default ui-corner-left" )

          .autocomplete({

            delay: 0,

            minLength: 0,

            source: $.proxy( this, "_source" )

          })

          .tooltip({

            tooltipClass: "ui-state-highlight"

          });

 

        this._on( this.input, {

          autocompleteselect: function( event, ui ) {

            ui.item.option.selected = true;

            this._trigger( "select", event, {

              item: ui.item.option

            });

          },

 

          autocompletechange: "_removeIfInvalid"

        });

      },

 

      _createShowAllButton: function() {

        var input = this.input,

          wasOpen = false;

 

        $( "<a>" )

          .attr( "tabIndex", -1 )

          .attr( "title", "Mostrar Items" )

          .tooltip()

          .appendTo( this.wrapper )

          .button({

            icons: {

              primary: "ui-icon-triangle-1-s"

            },

            text: false

          })

          .removeClass( "ui-corner-all" )

          .addClass( "custom-combobox-toggle ui-corner-right" )

          .mousedown(function() {

            wasOpen = input.autocomplete( "widget" ).is( ":visible" );

          })

          .click(function() {

            input.focus();

 

            // Close if already visible

            if ( wasOpen ) {

              return;

            }

 

            // Pass empty string as value to search for, displaying all results

            input.autocomplete( "search", "" );

          });

      },

 

      _source: function( request, response ) {

        var matcher = new RegExp( $.ui.autocomplete.escapeRegex(request.term), "i" );

        response( this.element.children( "option" ).map(function() {

          var text = $( this ).text();

          if ( this.value && ( !request.term || matcher.test(text) ) )

            return {

              label: text,

              value: text,

              option: this

            };

        }) );

      },

 

      _removeIfInvalid: function( event, ui ) {

 

        // Selected an item, nothing to do

        if ( ui.item ) {

          return;

        }

 

        // Search for a match (case-insensitive)

        var value = this.input.val(),

          valueLowerCase = value.toLowerCase(),

          valid = false;

        this.element.children( "option" ).each(function() {

          if ( $( this ).text().toLowerCase() === valueLowerCase ) {

            this.selected = valid = true;

            return false;

          }

        });

 

        // Found a match, nothing to do

        if ( valid ) {

          return;

        }

 

        // Remove invalid value

        this.input

          .val( "" )

          .attr( "title", "Datos no encontrados" )

          .tooltip( "open" );

        this.element.val( "" );

        this._delay(function() {

          this.input.tooltip( "close" ).attr( "title", "" );

        }, 2500 );

        this.input.autocomplete( "instance" ).term = "";

      },

 

      _destroy: function() {

        this.wrapper.remove();

        this.element.show();

      }

    });

  })( jQuery );

 

  $(function() {

    $( "#combobox" ).combobox();

    $( "#toggle" ).click(function() {

      $( "#combobox" ).toggle();

    });

  });

    </script>
    
    
    
    </head>
    
     <body>
        <form id="form1" runat="server">
            <div>
                <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods = "true">
                </asp:ScriptManager>
                
                <div class="ui-widget">
                    <label>Your preferred programming language: </label>

                    <asp:DropDownList ID="combobox" runat="server">
                    </asp:DropDownList>                  
                </div>
            </div>
        </form>
    </body>
</html>

