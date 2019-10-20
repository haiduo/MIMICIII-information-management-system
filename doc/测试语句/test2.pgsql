SET search_path TO mimiciii;
SELECT p.subject_id,
    i.icustay_id,i.dbsource,i.first_careunit,i.last_careunit,i.first_wardid,i.last_wardid,i.intime,i.outtime,i.los,
    dr.drg_type,dr.drg_code,dr.description,dr.drg_severity,dr.drg_mortality,
    l.charttime,l.value,l.valuenum,l.valueuom,l.flag,
    m.chartdate,m.charttime,m.spec_itemid,m.spec_type_desc,m.org_itemid,m.org_name,m.isolate_num,m.ab_itemid,m.ab_name,
    m.dilution_text,m.dilution_comparison,m.dilution_value,m.interpretation,
    pre.startdate,pre.enddate,pre.drug_type,pre.drug,pre.drug_name_poe,pre.drug_name_generic,pre.formulary_drug_cd,pre.gsn,
    pre.ndc,pre.prod_strength,pre.dose_val_rx,pre.dose_unit_rx,pre.form_val_disp,pre.form_unit_disp,pre.route,
    d_d.short_title,d_d.long_title,
    d_l.label,d_l.fluid,d_l.category,d_l.loinc_code
FROM patients p
INNER JOIN drgcodes dr  ON dr.subject_id =p.subject_id
INNER JOIN labevents l ON l.subject_id =p.subject_id
            INNER JOIN d_labitems d_l ON d_l.itemid=l.itemid 
INNER JOIN microbiologyevents m  ON m.subject_id =p.subject_id
INNER JOIN prescriptions pre  ON pre.subject_id =p.subject_id
INNER JOIN icustays i ON i.subject_id = p.subject_id 
INNER JOIN diagnoses_icd dia ON dia.subject_id =p.subject_id
            INNER JOIN d_icd_diagnoses d_d ON d_d.icd9_code=dia.icd9_code
limit 3 ;