<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"/>
	<xsl:template match="Root">
		<HTML>
			<BODY>
				<p>
					<H2>
						Library books:
					</H2>
				</p>
			</BODY>
			<BODY>
				<TABLE BORDER="2">
					<TR>
						<TD>
							<b>Name</b>
						</TD>
						<TD></TD>
						<b>Author</b>
					</TR>
					<xsl:apply-templates select="Book"/>
				</TABLE>
			</BODY>
		</HTML>
	</xsl:template>

</xsl:stylesheet>