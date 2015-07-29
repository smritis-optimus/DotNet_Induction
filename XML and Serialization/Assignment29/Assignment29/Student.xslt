<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns="http://www.w3.org/1999/xhtml" >
    
  <xsl:template match="/">
    <html>
      <body>
        <h2>Student Record</h2>
        <table>
          <tr bgcolor="teak">
            <th> Name</th>
            <th>Age</th>
            <th>Stream</th>
            <th>Address</th>
          </tr>
          <xsl:for-each select="Students/Student">
            <tr>
              <td>
                <xsl:value-of select="@name"/>
              </td>
              <td>
                <xsl:value-of select="@age"/>
              </td>
              <td>
                <xsl:value-of select="Stream"/>
              </td>
              <td>
                <xsl:value-of select="Address"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
