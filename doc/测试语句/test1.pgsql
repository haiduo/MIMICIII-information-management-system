SET search_path TO mimiciii;
SELECT  p.subject_id,
    incv.amount,incv.amountuom,incv.rate,incv.orderid,incv.linkorderid,incv.stopped,incv.newbottle,
    in_mv.secondaryordercategoryname,in_mv.ordercomponenttypedescription,in_mv.ordercategorydescription,in_mv.patientweight,
    in_mv.totalamount,in_mv.totalamountuom,in_mv.isopenbag,in_mv.continueinnextdept,in_mv.cancelreason,in_mv.statusdescription,
    in_mv.comments_editedby,in_mv.comments_canceledby,in_mv.comments_date,in_mv.originalamount,in_mv.originalrate,in_mv.ordercategoryname,
    o.charttime,o.value,o.valueuom,o.storetime,
    pr_i.seq_num,pr_i.icd9_code,
    cp.costcenter,cp.cpt_cd,cp.cpt_number,cp.cpt_suffix,cp.ticket_id_seq,cp.sectionheader,cp.subsectionheader,cp.description,
    dcpt.category,dcpt.sectionrange,dcpt.sectionheader,dcpt.subsectionrange,dcpt.subsectionheader,dcpt.codesuffix,dcpt.mincodeinsubsection,dcpt.maxcodeinsubsection,
    d_p.short_title,d_p.short_title
FROM patients p
INNER JOIN inputevents_cv incv   ON incv.subject_id =p.subject_id
INNER JOIN inputevents_mv in_mv   ON in_mv.subject_id =p.subject_id
INNER JOIN outputevents o  ON o.subject_id =p.subject_id
INNER JOIN procedures_icd pr_i  ON pr_i.subject_id =p.subject_id
            INNER JOIN d_icd_procedures d_p ON d_p.icd9_code=pr_i.icd9_code
INNER JOIN cptevents cp ON cp.subject_id =p.subject_id
            INNer JOIN d_cpt dcpt ON (cp.cpt_number BETWEEN dcpt.mincodeinsubsection AND dcpt.maxcodeinsubsection)
limit 5 ;