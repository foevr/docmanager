
namespace DocumentManager.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // 使用 DOCMGEntities 上下文实现应用程序逻辑。
    // TODO: 将应用程序逻辑添加到这些方法中或其他方法中。
    // TODO: 连接身份验证(Windows/ASP.NET Forms)并取消注释以下内容，以禁用匿名访问
    //还可考虑添加角色，以根据需要限制访问。
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class DOCMGDomainService : LinqToEntitiesDomainService<DOCMGEntities>
    {

        // TODO:
        // 考虑约束查询方法的结果。如果需要其他输入，
        //可向此方法添加参数或创建具有不同名称的其他查询方法。
        // 为支持分页，需要向“RL_USER_FIELD”查询添加顺序。
        public IQueryable<RL_USER_FIELD> GetRL_USER_FIELD()
        {
            return this.ObjectContext.RL_USER_FIELD;
        }

        public void InsertRL_USER_FIELD(RL_USER_FIELD rL_USER_FIELD)
        {
            if ((rL_USER_FIELD.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(rL_USER_FIELD, EntityState.Added);
            }
            else
            {
                this.ObjectContext.RL_USER_FIELD.AddObject(rL_USER_FIELD);
            }
        }

        public void UpdateRL_USER_FIELD(RL_USER_FIELD currentRL_USER_FIELD)
        {
            this.ObjectContext.RL_USER_FIELD.AttachAsModified(currentRL_USER_FIELD, this.ChangeSet.GetOriginal(currentRL_USER_FIELD));
        }

        public void DeleteRL_USER_FIELD(RL_USER_FIELD rL_USER_FIELD)
        {
            if ((rL_USER_FIELD.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(rL_USER_FIELD, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.RL_USER_FIELD.Attach(rL_USER_FIELD);
                this.ObjectContext.RL_USER_FIELD.DeleteObject(rL_USER_FIELD);
            }
        }

        // TODO:
        // 考虑约束查询方法的结果。如果需要其他输入，
        //可向此方法添加参数或创建具有不同名称的其他查询方法。
        // 为支持分页，需要向“TBCONTRACT”查询添加顺序。
        public IQueryable<TBCONTRACT> GetTBCONTRACT()
        {
            return this.ObjectContext.TBCONTRACT;
        }

        public void InsertTBCONTRACT(TBCONTRACT tBCONTRACT)
        {
            if ((tBCONTRACT.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBCONTRACT, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TBCONTRACT.AddObject(tBCONTRACT);
            }
        }

        public void UpdateTBCONTRACT(TBCONTRACT currentTBCONTRACT)
        {
            this.ObjectContext.TBCONTRACT.AttachAsModified(currentTBCONTRACT, this.ChangeSet.GetOriginal(currentTBCONTRACT));
        }

        public void DeleteTBCONTRACT(TBCONTRACT tBCONTRACT)
        {
            if ((tBCONTRACT.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBCONTRACT, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TBCONTRACT.Attach(tBCONTRACT);
                this.ObjectContext.TBCONTRACT.DeleteObject(tBCONTRACT);
            }
        }

        // TODO:
        // 考虑约束查询方法的结果。如果需要其他输入，
        //可向此方法添加参数或创建具有不同名称的其他查询方法。
        // 为支持分页，需要向“TBFIELD”查询添加顺序。
        public IQueryable<TBFIELD> GetTBFIELD()
        {
            return this.ObjectContext.TBFIELD;
        }

        public void InsertTBFIELD(TBFIELD tBFIELD)
        {
            if ((tBFIELD.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBFIELD, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TBFIELD.AddObject(tBFIELD);
            }
        }

        public void UpdateTBFIELD(TBFIELD currentTBFIELD)
        {
            this.ObjectContext.TBFIELD.AttachAsModified(currentTBFIELD, this.ChangeSet.GetOriginal(currentTBFIELD));
        }

        public void DeleteTBFIELD(TBFIELD tBFIELD)
        {
            if ((tBFIELD.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBFIELD, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TBFIELD.Attach(tBFIELD);
                this.ObjectContext.TBFIELD.DeleteObject(tBFIELD);
            }
        }

        // TODO:
        // 考虑约束查询方法的结果。如果需要其他输入，
        //可向此方法添加参数或创建具有不同名称的其他查询方法。
        // 为支持分页，需要向“TBMODULE”查询添加顺序。
        public IQueryable<TBMODULE> GetTBMODULE()
        {
            return this.ObjectContext.TBMODULE;
        }

        public void InsertTBMODULE(TBMODULE tBMODULE)
        {
            if ((tBMODULE.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBMODULE, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TBMODULE.AddObject(tBMODULE);
            }
        }

        public void UpdateTBMODULE(TBMODULE currentTBMODULE)
        {
            this.ObjectContext.TBMODULE.AttachAsModified(currentTBMODULE, this.ChangeSet.GetOriginal(currentTBMODULE));
        }

        public void DeleteTBMODULE(TBMODULE tBMODULE)
        {
            if ((tBMODULE.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBMODULE, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TBMODULE.Attach(tBMODULE);
                this.ObjectContext.TBMODULE.DeleteObject(tBMODULE);
            }
        }

        // TODO:
        // 考虑约束查询方法的结果。如果需要其他输入，
        //可向此方法添加参数或创建具有不同名称的其他查询方法。
        // 为支持分页，需要向“TBSYSCODE”查询添加顺序。
        public IQueryable<TBSYSCODE> GetTBSYSCODE()
        {
            return this.ObjectContext.TBSYSCODE;
        }

        public void InsertTBSYSCODE(TBSYSCODE tBSYSCODE)
        {
            if ((tBSYSCODE.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBSYSCODE, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TBSYSCODE.AddObject(tBSYSCODE);
            }
        }

        public void UpdateTBSYSCODE(TBSYSCODE currentTBSYSCODE)
        {
            this.ObjectContext.TBSYSCODE.AttachAsModified(currentTBSYSCODE, this.ChangeSet.GetOriginal(currentTBSYSCODE));
        }

        public void DeleteTBSYSCODE(TBSYSCODE tBSYSCODE)
        {
            if ((tBSYSCODE.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBSYSCODE, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TBSYSCODE.Attach(tBSYSCODE);
                this.ObjectContext.TBSYSCODE.DeleteObject(tBSYSCODE);
            }
        }

        // TODO:
        // 考虑约束查询方法的结果。如果需要其他输入，
        //可向此方法添加参数或创建具有不同名称的其他查询方法。
        // 为支持分页，需要向“TBSYSCODETYPE”查询添加顺序。
        public IQueryable<TBSYSCODETYPE> GetTBSYSCODETYPE()
        {
            return this.ObjectContext.TBSYSCODETYPE;
        }

        public void InsertTBSYSCODETYPE(TBSYSCODETYPE tBSYSCODETYPE)
        {
            if ((tBSYSCODETYPE.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBSYSCODETYPE, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TBSYSCODETYPE.AddObject(tBSYSCODETYPE);
            }
        }

        public void UpdateTBSYSCODETYPE(TBSYSCODETYPE currentTBSYSCODETYPE)
        {
            this.ObjectContext.TBSYSCODETYPE.AttachAsModified(currentTBSYSCODETYPE, this.ChangeSet.GetOriginal(currentTBSYSCODETYPE));
        }

        public void DeleteTBSYSCODETYPE(TBSYSCODETYPE tBSYSCODETYPE)
        {
            if ((tBSYSCODETYPE.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBSYSCODETYPE, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TBSYSCODETYPE.Attach(tBSYSCODETYPE);
                this.ObjectContext.TBSYSCODETYPE.DeleteObject(tBSYSCODETYPE);
            }
        }

        // TODO:
        // 考虑约束查询方法的结果。如果需要其他输入，
        //可向此方法添加参数或创建具有不同名称的其他查询方法。
        // 为支持分页，需要向“TBUSER”查询添加顺序。
        public IQueryable<TBUSER> GetTBUSER()
        {
            return this.ObjectContext.TBUSER;
        }

        public void InsertTBUSER(TBUSER tBUSER)
        {
            if ((tBUSER.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBUSER, EntityState.Added);
            }
            else
            {
                this.ObjectContext.TBUSER.AddObject(tBUSER);
            }
        }

        public void UpdateTBUSER(TBUSER currentTBUSER)
        {
            this.ObjectContext.TBUSER.AttachAsModified(currentTBUSER, this.ChangeSet.GetOriginal(currentTBUSER));
        }

        public void DeleteTBUSER(TBUSER tBUSER)
        {
            if ((tBUSER.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(tBUSER, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.TBUSER.Attach(tBUSER);
                this.ObjectContext.TBUSER.DeleteObject(tBUSER);
            }
        }
    }
}


