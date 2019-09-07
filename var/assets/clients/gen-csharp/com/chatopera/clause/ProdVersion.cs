/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace com.chatopera.clause
{

  /// <summary>
  /// 上线版本
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ProdVersion : TBase
  {
    private string _chatbotID;
    private string _version;
    private bool _active;
    private bool _latest;
    private string _id;
    private string _operated;
    private string _notes;
    private string _createdate;

    public string ChatbotID
    {
      get
      {
        return _chatbotID;
      }
      set
      {
        __isset.chatbotID = true;
        this._chatbotID = value;
      }
    }

    public string Version
    {
      get
      {
        return _version;
      }
      set
      {
        __isset.version = true;
        this._version = value;
      }
    }

    public bool Active
    {
      get
      {
        return _active;
      }
      set
      {
        __isset.active = true;
        this._active = value;
      }
    }

    public bool Latest
    {
      get
      {
        return _latest;
      }
      set
      {
        __isset.latest = true;
        this._latest = value;
      }
    }

    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string Operated
    {
      get
      {
        return _operated;
      }
      set
      {
        __isset.operated = true;
        this._operated = value;
      }
    }

    public string Notes
    {
      get
      {
        return _notes;
      }
      set
      {
        __isset.notes = true;
        this._notes = value;
      }
    }

    public string Createdate
    {
      get
      {
        return _createdate;
      }
      set
      {
        __isset.createdate = true;
        this._createdate = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool chatbotID;
      public bool version;
      public bool active;
      public bool latest;
      public bool id;
      public bool operated;
      public bool notes;
      public bool createdate;
    }

    public ProdVersion() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                ChatbotID = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Version = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                Active = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Bool) {
                Latest = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                Operated = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                Notes = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.String) {
                Createdate = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("ProdVersion");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (ChatbotID != null && __isset.chatbotID) {
          field.Name = "chatbotID";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ChatbotID);
          oprot.WriteFieldEnd();
        }
        if (Version != null && __isset.version) {
          field.Name = "version";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Version);
          oprot.WriteFieldEnd();
        }
        if (__isset.active) {
          field.Name = "active";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Active);
          oprot.WriteFieldEnd();
        }
        if (__isset.latest) {
          field.Name = "latest";
          field.Type = TType.Bool;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Latest);
          oprot.WriteFieldEnd();
        }
        if (Id != null && __isset.id) {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Id);
          oprot.WriteFieldEnd();
        }
        if (Operated != null && __isset.operated) {
          field.Name = "operated";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Operated);
          oprot.WriteFieldEnd();
        }
        if (Notes != null && __isset.notes) {
          field.Name = "notes";
          field.Type = TType.String;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Notes);
          oprot.WriteFieldEnd();
        }
        if (Createdate != null && __isset.createdate) {
          field.Name = "createdate";
          field.Type = TType.String;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Createdate);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ProdVersion(");
      bool __first = true;
      if (ChatbotID != null && __isset.chatbotID) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ChatbotID: ");
        __sb.Append(ChatbotID);
      }
      if (Version != null && __isset.version) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Version: ");
        __sb.Append(Version);
      }
      if (__isset.active) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Active: ");
        __sb.Append(Active);
      }
      if (__isset.latest) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Latest: ");
        __sb.Append(Latest);
      }
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Operated != null && __isset.operated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Operated: ");
        __sb.Append(Operated);
      }
      if (Notes != null && __isset.notes) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Notes: ");
        __sb.Append(Notes);
      }
      if (Createdate != null && __isset.createdate) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Createdate: ");
        __sb.Append(Createdate);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}