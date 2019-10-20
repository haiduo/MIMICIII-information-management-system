SET search_path TO mimiciii;
SELECT p.subject_id,p.gender,
    --,ROUND((cast(a.admittime as date) - cast(p.dob as date)) / 365.2 ) as age,a.religion,a.insurance,a.language,a.hadm_id,a.marital_status,a.ethnicity,
    p.dob,p.dod,p.dod_hosp,p.dod_ssn,p.expire_flag
    --a.admittime,a.dischtime,a.deathtime,a.admission_type,
    --a.admission_location,a.discharge_location,a.edregtime,a.edouttime,a.diagnosis,a.hospital_expire_flag,a.has_chartevents_data,
    --c.charttime,c.storetime,c.cgid,c.value,c.valuenum,c.valueuom,c.warning,c.error,c.resultstatus,c.stopped
    --d.itemid,d.label,d.abbreviation,d.linksto,d.category,d.unitname,d.param_type,d.conceptid,
    --ca.submit_wardid,ca.submit_careunit,ca.curr_wardid,ca.curr_careunit,ca.callout_wardid,ca.callout_service,ca.request_tele,
    --ca.request_resp,ca.request_cdiff,ca.request_mrsa,ca.request_vre,ca.callout_outcome,ca.discharge_wardid,ca.acknowledge_status,
    --ca.createtime,ca.updatetime,ca.acknowledgetime,ca.outcometime,ca.firstreservationtime,ca.currentreservationtime,ca.submit_wardid,
    --s.transfertime,s.prev_service,s.curr_service,
    --t.eventtype,t.prev_careunit,t.curr_careunit,t.prev_wardid,t.curr_wardid,
    --n.category,n.description,n.iserror,n.text,n.chartdate
FROM patients p
--INNER JOIN admissions a ON a.subject_id = p.subject_id
--INNER JOIN chartevents c ON c.subject_id =p.subject_id
            --INNER JOIN d_items d ON d.itemid =c.itemid 
            --INNER JOIN caregivers car ON car.cgid = c.cgid   
--INNER JOIN callout ca ON ca.subject_id =p.subject_id
--INNER JOIN services s ON s.subject_id =p.subject_id 
--INNER JOIN transfers t ON t.subject_id =p.subject_id
--INNER JOIN noteevents n   ON n.subject_id =p.subject_id
;