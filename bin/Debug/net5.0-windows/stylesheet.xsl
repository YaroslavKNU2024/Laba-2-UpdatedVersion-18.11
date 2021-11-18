<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"/>
	<xsl:template match="MyRoot">
		<TABLE BORDER="2">
			<TR>
				<xsl:for-each select="Book">
					<TR>
						<TD>
							<TABLE BORDER="1" WIDTH="1200">
								<TR>
									<th style="width:10%;">
										<p align="left">Name of  a book</p>
									</th>
									<th>
										<p align="left">
											<xsl:value-of select ="@BK_NAME"/>
										</p>
									</th>
								</TR>
							</TABLE>
							<TABLE BORDER="1" WIDTH="1200">
								<TR>
									<th style="width:10%;">
										<p align="left">Author</p>
									</th>
									<th>
										<p align="left">
											<xsl:value-of select ="@AU"/>
										</p>
									</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Anotation</p>
									</th>
									<th>
										<p align="left">
											<xsl:value-of select ="@AN"/>
										</p>
									</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Qualification properties</p>
									</th>
									<th>
										<p align="left">
											<xsl:value-of select ="@PUB"/>
										</p>
									</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Faculty</p>
									</th>
									<th>
										<p align="left">
											<xsl:value-of select ="@FAC"/>
										</p>
									</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Department</p>
									</th>
									<th>
										<p align="left">
											<xsl:value-of select ="@DE"/>
										</p>
									</th>
								</TR>
								<TR>
									<th style="width:10%;">
										<p align="left">Position</p>
									</th>
									<th>
										<p align="left">
											<xsl:value-of select ="@POS"/>
										</p>
									</th>
								</TR>
							</TABLE>
						</TD>
						
					</TR>
				</xsl:for-each>
			</TR>
			<xsl:apply-templates select="Book"/>
		</TABLE>
	</xsl:template>

</xsl:stylesheet>