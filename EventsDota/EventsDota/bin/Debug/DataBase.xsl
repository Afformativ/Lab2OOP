<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"/>
    <xsl:template match="EventsDataBase">
      <html>
        <head>
          <title>Dota 2 Events by Hrabar Oleksandr</title>
          <link rel="shortcut icon" href="http://www.iconj.com/ico/3/l/3lm7q58dc9.ico" type="image/x-icon" />
          <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        </head>
      <table border="3" cellspacing="0">
        <xsl:for-each select="Event">
          <TR>
            <TD>
              <TABLE BORDER="5" WIDTH="1200">
                <TR>
                  <th style="width:10%;">
                    <p align="left">Value</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@VALUE"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">Name</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@NAME"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">Start Date</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@START"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">End Date</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@END"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">Country</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@COUNTRY"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">City</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@CITY"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">Prizepool</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@PRIZEPOOL"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">DPCPoints</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@DPC"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">Winner</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@WINNER"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">Runner-Up</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@RUNNERUP"/>
                    </p>
                  </th>
                </TR>
                <TR>
                  <th style="width:10%;">
                    <p align="left">Number of teams</p>
                  </th>
                  <th style="widht:90%;">
                    <p align="left">
                      <xsl:value-of select="@NUMBEROFTEAMS"/>
                    </p>
                  </th>
                </TR>
              </TABLE>
            </TD>
          </TR>
        </xsl:for-each>
      </table>
      </html>
    </xsl:template>
</xsl:stylesheet>
