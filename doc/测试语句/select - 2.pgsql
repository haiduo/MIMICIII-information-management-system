SET search_path TO mimiciii;
SELECT p.subject_id,a.hadm_id,i.icustay_id,d.itemid,a.insurance,a.language,p.gender,ROUND((cast(a.admittime as date) - cast(p.dob as date)) / 365.2 ) as age,a.religion, 
    a.marital_status,a.ethnicity,p.dob,p.dod,p.dod_hosp,p.dod_ssn,p.expire_flag,a.admittime,a.dischtime,a.deathtime,a.admission_type,
    a.admission_location,a.discharge_location,a.edregtime,a.edouttime,a.diagnosis,a.hospital_expire_flag,a.has_chartevents_data,
    i.dbsource,i.first_careunit,i.last_careunit,i.first_wardid,i.last_wardid,i.intime,i.outtime,i.los,
    c.charttime,c.storetime,c.cgid,c.value,c.valuenum,c.valueuom,c.warning,c.error,c.resultstatus,c.stopped,
    d.label,d.abbreviation,d.linksto,d.category,d.unitname,d.param_type,d.conceptid,
    ca.submit_wardid,ca.submit_careunit,ca.curr_wardid,ca.curr_careunit,ca.callout_wardid,ca.callout_service,ca.request_tele,
    ca.request_resp,ca.request_cdiff,ca.request_mrsa,ca.request_vre,ca.callout_outcome,ca.discharge_wardid,ca.acknowledge_status,
    ca.createtime,ca.updatetime,ca.acknowledgetime,ca.outcometime,ca.firstreservationtime,ca.currentreservationtime,ca.submit_wardid,
    s.transfertime,s.prev_service,s.curr_service,
    t.eventtype,t.prev_careunit,t.curr_careunit,t.prev_wardid,t.curr_wardid,
    car.cgid,car.label,car.description,
    in_cv.amount,in_cv.amountuom,in_cv.rate,in_cv.orderid,in_cv.linkorderid,in_cv.stopped,in_cv.newbottle,in_mv.ordercategoryname,
    in_mv.secondaryordercategoryname,in_mv.ordercomponenttypedescription,in_mv.ordercategorydescription,in_mv.patientweight,
    in_mv.totalamount,in_mv.totalamountuom,in_mv.isopenbag,in_mv.continueinnextdept,in_mv.cancelreason,in_mv.statusdescription,
    in_mv.comments_editedby,in_mv.comments_canceledby,in_mv.comments_date,in_mv.originalamount,in_mv.originalrate,n.chartdate,
    n.category,n.description,n.iserror,n.text,
    o.charttime,o.value,o.valueuom,o.storetime,
    pr_i.seq_num,pr_i.icd9_code,
    cp.costcenter,cp.cpt_cd,cp.cpt_number,cp.cpt_suffix,cp.ticket_id_seq,cp.sectionheader,cp.subsectionheader,cp.description,
    dr.drg_type,dr.drg_code,dr.description,dr.drg_severity,dr.drg_mortality,
    l.charttime,l.value,l.valuenum,l.valueuom,l.flag,
    m.chartdate,m.charttime,m.spec_itemid,m.spec_type_desc,m.org_itemid,m.org_name,m.isolate_num,m.ab_itemid,m.ab_name,
    m.dilution_text,m.dilution_comparison,m.dilution_value,m.interpretation,
    pre.startdate,pre.enddate,pre.drug_type,pre.drug,pre.drug_name_poe,pre.drug_name_generic,pre.formulary_drug_cd,pre.gsn,
    pre.ndc,pre.prod_strength,pre.dose_val_rx,pre.dose_unit_rx,pre.form_val_disp,pre.form_unit_disp,pre.route,
    d_d.short_title,d_d.long_title,d_p.short_title,d_p.short_title,
    d_l.label,d_l.fluid,d_l.category,d_l.loinc_code
FROM patients p
INNER JOIN admissions a ON a.subject_id = p.subject_id
INNER JOIN chartevents c ON c.subject_id =p.subject_id
            INNER JOIN d_items d ON d.itemid =c.itemid 
            INNER JOIN caregivers car ON car.cgid = c.cgid   
INNER JOIN callout ca ON ca.subject_id =p.subject_id
INNER JOIN services s ON s.subject_id =p.subject_id 
INNER JOIN transfers t ON t.subject_id =p.subject_id
INNER JOIN inputevents_cv in_cv   ON in_cv.subject_id =p.subject_id
INNER JOIN inputevents_mv in_mv   ON in_mv.subject_id =p.subject_id
INNER JOIN noteevents n   ON n.subject_id =p.subject_id
INNER JOIN outputevents o  ON o.subject_id =p.subject_id
INNER JOIN procedures_icd pr_i  ON pr_i.subject_id =p.subject_id
            INNER JOIN d_icd_procedures d_p ON d_p.icd9_code=pr_i.icd9_code
INNER JOIN cptevents cp ON cp.subject_id =p.subject_id
INNER JOIN drgcodes dr  ON dr.subject_id =p.subject_id
INNER JOIN labevents l ON l.subject_id =p.subject_id
            INNER JOIN d_labitems d_l ON d_l.itemid=l.itemid 
INNER JOIN microbiologyevents m  ON m.subject_id =p.subject_id
INNER JOIN prescriptions pre  ON pre.subject_id =p.subject_id
INNER JOIN icustays i ON i.subject_id = p.subject_id 
INNER JOIN diagnoses_icd dia ON dia.subject_id =p.subject_id
            INNER JOIN d_icd_diagnoses d_d ON d_d.icd9_code=dia.icd9_code
ORDER BY p.subject_id,a.hadm_id,a.admittime
limit 5 ;