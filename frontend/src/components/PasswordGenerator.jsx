import React, { useState } from "react";
import axios from "axios";
import "./PasswordGenerator.css";

const PasswordGenerator = () => {
  const [password, setPassword] = useState("");

  const generatePassword = async () => {
    try {
      const response = await axios.get(
        "http://localhost:5073/api/password/generate"
      );
      setPassword(response.data.password);
    } catch (error) {
      console.error("Error generating password:", error);
      setPassword("Error generating password");
    }
  };

  return (
    <div className="password-generator">
      <div className="container">
        <h1>Password Generator</h1>
        <div className="password-display">
          {password || "Your password will appear here"}
        </div>
        <button onClick={generatePassword} className="generate-button">
          Generate Password
          <span className="icon">↻</span>
        </button>
      </div>
    </div>
  );
};

export default PasswordGenerator;
