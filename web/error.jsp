<%-- 
    Document   : error
    Created on : Feb 17, 2020, 1:08:37 PM
    Author     : hoang
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Error Page</h1>
        <%
            String error = (String) request.getAttribute("ERROR");
        %>
        <h2>
            <font color="red">
                <%= error %>
            </font>
        </h2>
            <a href="index.jsp">Back to Login page</a>
    </body>
</html>
