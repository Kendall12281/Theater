<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <style>
          table {
          border-collapse: collapse;
          width: 100%;
          }

          th, td {
          text-align: left;
          padding: 4px;
          }

          tr:nth-child(even){background-color: #f2f2f2}

          th {
          background-color: #00ADE6;
          color: white;
          }
        </style>
      </head>
      <body>
        <h2>Recibo</h2>
        <table>
          <tr>
            <td>Número:</td>
            <td>
              <xsl:value-of select="Recibo/Consecutivo"/>
            </td>
          </tr>
          <tr>
            <th>Teatro:</th>
            <th>
              <xsl:value-of select="Recibo/Teatro/@Nombre"/>
            </th>
          </tr>
          
          <tr>
            <td>Cartelera</td>
            <td>
              <xsl:value-of select="Recibo/Teatro/Cartelera"/> (<xsl:value-of select="Recibo/Teatro/Cartelera/@Codigo"/>)
            </td>
          </tr>
          <tr>
            <td>Horario</td>
            <td>
              <xsl:value-of select="Recibo/Teatro/Horario"/>
            </td>
          </tr>
          <tr>
            <th colspan="2">Tickets</th>            
          </tr>
          <xsl:for-each select="Recibo/Tickets/Ticket">
            <tr>
              <td>
                <xsl:value-of select="."/>                
              </td>
              <td>
                Cantidad: <xsl:value-of select="./@Cantidad"/>
              </td>
            </tr>
          </xsl:for-each>

          <tr>
            <td>Descuento:</td>
            <td>
              <xsl:value-of select="Recibo/Descuento"/>
            </td>
          </tr>

          <tr>
            <td>Impuesto:</td>
            <td>
              $ <xsl:value-of select="Recibo/Total/@Impuesto"/>
            </td>
          </tr>
          <tr>
            <th>Total:</th>
            <th>
              $ <xsl:value-of select="Recibo/Total"/>
            </th>
          </tr>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>