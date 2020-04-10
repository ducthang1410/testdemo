/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package daos;

import dtos.RegistrationDTO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import utils.MyConnection;

/**
 *
 * @author hoang
 */
public class RegistrationDAO {

    private Connection conn;
    private PreparedStatement preStmt;
    private ResultSet rs;

    private void closeConn() throws SQLException {
        if (rs != null) {
            rs.close();
        }
        if (preStmt != null) {
            preStmt.close();
        }
        if (conn != null) {
            conn.close();
        }
    }

    public String checkLogin(String username, String password) throws SQLException, ClassNotFoundException {
        String role = "failed";
        try {
            conn = MyConnection.getConnection();
            String sql = "SELECT [Role] FROM [Registration] WHERE [Username] = ? AND [Password] = ?";
            preStmt = conn.prepareStatement(sql);
            preStmt.setString(1, username);
            preStmt.setString(2, password);
            rs = preStmt.executeQuery();
            if (rs.next()) {
                role = rs.getString("Role");
            }
        } finally {
            closeConn();
        }
        return role;
    }

    public List<RegistrationDTO> findByLikeName(String search) throws ClassNotFoundException, SQLException {
        List<RegistrationDTO> result = null;
        String username, fullname, role;
        RegistrationDTO dto = null;
        try {
            conn = MyConnection.getConnection();
            String sql = "SELECT [Username], [Fullname], [Role] FROM [Registration] WHERE [Fullname] LIKE ?";
            preStmt = conn.prepareStatement(sql);
            preStmt.setString(1, "%" + search + "%");
            rs = preStmt.executeQuery();
            result = new ArrayList<>();
            while (rs.next()) {
                username = rs.getString("Username");
                fullname = rs.getString("Fullname");
                role = rs.getString("Role");
                dto = new RegistrationDTO(username, fullname, role);
                result.add(dto);
            }
        } finally {
            closeConn();
        }
        return result;
    }

    public boolean delete(String username) throws ClassNotFoundException, SQLException {
        boolean deleted = false;
        try {
            conn = MyConnection.getConnection();
            String sql = "DELETE FROM [Registration] WHERE [Username] = ?";
            preStmt = conn.prepareStatement(sql);
            preStmt.setString(1, username);
            deleted = preStmt.executeUpdate() > 0;
        } finally {
            closeConn();
        }
        return deleted;
    }

    public RegistrationDTO findByPrimaryKey(String key) throws ClassNotFoundException, SQLException {
        RegistrationDTO dto = null;
        try {
            conn = MyConnection.getConnection();
            String sql = "SELECT [Fullname], [Role] FROM [Registration] WHERE [Username] = ?";
            preStmt = conn.prepareStatement(sql);
            preStmt.setString(1, key);
            rs = preStmt.executeQuery();
            if (rs.next()) {
                String fullname = rs.getString("Fullname");
                String role = rs.getString("Role");
                dto = new RegistrationDTO(key, fullname, role);
            }
        } finally {
            closeConn();
        }
        return dto;
    }

    public boolean updateByDTO(RegistrationDTO dto) throws ClassNotFoundException, SQLException {
        boolean updated = false;
        try {
            conn = MyConnection.getConnection();
            String sql = "UPDATE [Registration] SET [Fullname] = ?, [Role] = ? WHERE [Username] = ?";
            preStmt = conn.prepareStatement(sql);
            preStmt.setString(1, dto.getFullname());
            preStmt.setString(2, dto.getRole());
            preStmt.setString(3, dto.getUsername());
            updated = preStmt.executeUpdate() > 0;
        } finally {
            closeConn();
        }
        return updated;
    }
    
    public boolean addDTO(RegistrationDTO dto) throws ClassNotFoundException, SQLException{
        boolean inserted = false;
        try {
            conn = MyConnection.getConnection();
            String sql = "INSERT INTO [Registration] ([Username], [Password], [Fullname], [Role]) VALUES (?, ?, ?, ?)";
            preStmt = conn.prepareStatement(sql);
            preStmt.setString(1, dto.getUsername());
            preStmt.setString(2, dto.getPassword());
            preStmt.setString(3, dto.getFullname());
            preStmt.setString(4, dto.getRole());
            inserted = preStmt.executeUpdate() > 0;
        } finally {
            closeConn();
        }
        return inserted;
    }

}
