using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace CSharp.Beginner.Microservice.Restful.Models;

/**
 *  UserModel.cs
 * 
 *  Author   Cristian Hume Henriquez
 *  Version  1.0.0
 *  Created  2022-11-27
 *  Modified 2022-11-28 
 */
public class UserModel
{
    #region [PRIVATE-FIELDS]
    private Int32 _id;
    private String _firstName;
    private String _lastName;
    private String _nationality;
    private String _occupation;
    private String _phone;
    private String _email;
    private List<String> _knownFor;
    private List<String> _awards;
    #endregion [PRIVATE-FIELDS]

    #region [PUBLIC-CONSTRUCTORS]
    public UserModel()
    {
        _id = 0;
        _firstName = String.Empty;
        _lastName = String.Empty;
        _nationality = String.Empty;
        _occupation = String.Empty;
        _phone = String.Empty;
        _email = String.Empty;
        _knownFor = new List<string>();
        _awards = new List<string>();
    }
    #endregion [PUBLIC-CONSTRUCTORS]

    #region [PUBLIC-PROPERTIES]
    [JsonPropertyName("id")]
    public Int32 Id
    {
        get { return _id; }
        set { _id = value; }
    }

    [Required]
    [JsonPropertyName("first_name")]
    public String FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    [Required]
    [JsonPropertyName("last_name")]
    public String LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    [Required]
    [JsonPropertyName("nationality")]
    public String Nationality
    {
        get { return _nationality; }
        set { _nationality = value; }
    }

    [Required]
    [JsonPropertyName("occupation")]
    public String Occupation
    {
        get { return _occupation; }
        set { _occupation = value; }
    }

    [JsonPropertyName("phone")]
    public String Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }

    [JsonPropertyName("email")]
    public String Email
    {
        get { return _email; }
        set { _email = value; }
    }

    [JsonPropertyName("known_for")]
    public List<String> KnownFor
    {
        get { return _knownFor; }
        set { _knownFor = value; }
    }

    [JsonPropertyName("awards")]
    public List<String> Awards
    {
        get { return _awards; }
        set { _awards = value; }
    }
    #endregion [PUBLIC-PROPERTIES]
}
